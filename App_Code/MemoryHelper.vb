Imports System

Imports System.Runtime.InteropServices


Public Class MemoryHelper
    ''' <summary>
    ''' List of strings with COM Objects that are needed to invoke Close method in ReleaseAndCleanObject.
    ''' </summary>
    Private Shared COMObjectsWithClose As New List(Of String)(New String() {"adodb.recordset", "adodb.connection"})
    ''' <summary>
    ''' Function to call the Garbage Collector AND reclaim any available memory.
    ''' </summary>
    Public Shared Sub ReleaseMemory()
        Try
            'GC.Collect()
            'GC.WaitForPendingFinalizers()
        Catch
        End Try
    End Sub
    ''' <summary>
    ''' In VB6, it was possible to copy variables using API functions LIKE hMemCpy OR 
    ''' statements LIKE LSET.
    ''' This helper function is used to provide a mechanism to easily turn an structure into
    ''' an array of bytes that can then be easily manipulated
    ''' </summary>
    ''' <param name="obj">The structure that will be copied to an array of bytes</param>
    ''' <returns>An array of bytes containing a copy of the information hold by a struct</returns>
    Public Shared Function StructureToByteArray(ByVal obj As Object) As Byte()
        Dim len As Integer = Marshal.SizeOf(obj)
        Dim arr As Byte() = New Byte(len - 1) {}
        Dim ptr As IntPtr = Marshal.AllocHGlobal(len)
        Marshal.StructureToPtr(obj, ptr, True)
        Marshal.Copy(ptr, arr, 0, len)
        Marshal.FreeHGlobal(ptr)
        Return arr
    End Function
    ''' <summary>
    ''' This overload calls ByteArrayToStructure assuming an startIndex of 0
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="bytearray"></param>
    ''' <param name="obj"></param>
    Public Shared Sub ByteArrayToStructure(Of T)(ByVal bytearray As Byte(), ByRef obj As T)
        ByteArrayToStructure(bytearray, 0, obj)
    End Sub
    ''' <summary>
    ''' In VB6, it was possible to copy variables using API functions LIKE hMemCpy OR 
    ''' statements LIKE LSET.
    ''' This helper function is used to provide a mechanism to easily take an array
    ''' of bytes AND put that information inside an struct.
    ''' </summary>
    ''' <param name="bytearray">The array containing the information</param>
    ''' <param name="startIndex">This index established the place WHERE to start copying data FROM this array to the structure</param>
    ''' <param name="obj">The target structure</param>
    Public Shared Sub ByteArrayToStructure(Of T)(ByVal bytearray As Byte(), ByVal startIndex As Integer, ByRef obj As T)
        Dim len As Integer = Marshal.SizeOf(obj)
        Dim i As IntPtr = Marshal.AllocHGlobal(len)
        If startIndex + len > bytearray.Length Then
            Throw New IndexOutOfRangeException("The array does not hold enough information to UPDATE the structure")
        End If
        Marshal.Copy(bytearray, startIndex, i, len)
        obj = DirectCast(Marshal.PtrToStructure(i, GetType(T)), T)
        Marshal.FreeHGlobal(i)
    End Sub
    ''' <summary>
    ''' Copies data FROM one struct to another.
    ''' This will be an exact copy of bytes.
    ''' Users must be aware that reference types 
    ''' might still be pointing to the same memory areas.
    ''' Source AND Destination might have different struct types
    ''' </summary>
    ''' <typeparam name="T2">Destination Struct Type</typeparam>
    ''' <typeparam name="T1">Source Struct Type</typeparam>
    ''' <param name="dest">Destination Struct</param>
    ''' <param name="source">Source Struct</param>
    Public Shared Sub CopyMemory(Of T2, T1)(ByRef dest As T2, ByVal source As T1)
        Dim data As Byte() = Nothing
        data = StructureToByteArray(source)
        Dim temp As Object = dest
        ByteArrayToStructure(data, temp)
        dest = DirectCast(temp, T2)
    End Sub
End Class
