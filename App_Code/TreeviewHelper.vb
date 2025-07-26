Imports System
Imports System.Data
Imports UNET.Utility
Imports System.Configuration
Imports System.Data.SqlClient
Imports UNET.DataAdapter


Public Class TreeviewHelper
    Private _querySt As String
    Private _categoryDT As DataTable

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="querySt"></param>
    ''' <remarks></remarks>
    Sub New(ByVal querySt As String)
        _querySt = querySt
        _categoryDT = ExecSQLReturnDT(querySt)
    End Sub

    Public Function popularTreeview(ByVal ppTreeview As TreeView, Optional ByVal rootLevel As Integer = 0, Optional ByVal vt As Integer = 0)
        ppTreeview.Nodes.Clear()
        ' Clear any existing items
        ppTreeview.BeginUpdate()
        ' prevent overhead AND flicker
        Dim node As TreeNode
        Dim cate As Category
        For Each cat As DataRow In _categoryDT.Select(String.Format("ParentID = {0}", rootLevel))
            ' iterate through the categories
            'If ConvertToIDSafe(cat("Parent")) = baseParent Then
            'cate = New Category(ConvertToIDSafe(cat("FirstOfMaSo")), ConvertToIDSafe(cat("ParentID")), String.Format("{0} {1}", cat("SoHieu"), cat("FirstOfTen")))
            If vt = 1 Then
                cate = New Category(ConvertToIDSafe(cat("FirstOfMaSo")), ConvertToIDSafe(cat("ParentID")), String.Format("{0}   {1}   {2}", cat("SoHieu"), cat("FirstOfTen"), IIf(IsDBNull(cat("SHTK")), 0, cat("SHTK"))))
            Else
                cate = New Category(ConvertToIDSafe(cat("FirstOfMaSo")), ConvertToIDSafe(cat("ParentID")), String.Format("{0}   {1}", cat("SoHieu"), cat("FirstOfTen")))
            End If
            ' found a matching root item
            node = ppTreeview.Nodes.Add(cate.NodeText)
            ' add it to the tree
            node.Tag = cate
            ' send the category into the tag for future processing
            ' load all the children of this node
            getChildren(node, vt)
            'End If
        Next
        ' load all the lowest tree nodes
        ppTreeview.EndUpdate()
        ' re-enable the tree
        ppTreeview.Refresh()
        ' refresh the treeview display
        Return 1
    End Function
    ''' <summary>
    ''' Recursive tree loader. Passes back in a node to retireve its childre
    ''' until there are no more children for this node.
    ''' </summary>
    ''' <param name="node__1"></param>
    ''' <remarks></remarks>
    Private Sub getChildren(ByVal node__1 As TreeNode, Optional ByVal vt As Integer = 0)
        Dim Node__2 As TreeNode = Nothing
        Dim nodeCat As Category = DirectCast(node__1.Tag, Category)
        ' get the category for this node

        For Each cat As DataRow In _categoryDT.Rows
            ' locate all children of this category
            If ConvertToIDSafe(cat("ParentID")) = nodeCat.ID Then
                Dim cate As Category
                If vt = 1 Then
                    cate = New Category(ConvertToIDSafe(cat("FirstOfMaSo")), ConvertToIDSafe(cat("ParentID")), String.Format("{0} {1} {2}", cat("SoHieu"), cat("FirstOfTen"), IIf(vt = 1, IIf(IsDBNull(cat("SHTK")), 0, cat("SHTK")), String.Empty)))
                Else
                    cate = New Category(ConvertToIDSafe(cat("FirstOfMaSo")), ConvertToIDSafe(cat("ParentID")), String.Format("{0} {1}", cat("SoHieu"), cat("FirstOfTen")))
                End If
                ' found a child
                Node__2 = node__1.Nodes.Add(cate.NodeText)
                ' add the child
                Node__2.Tag = cate
                ' SET its tag to its category
                ' find this child's children
                getChildren(Node__2, vt)
            End If
        Next
    End Sub
End Class
''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Class Category
    Public ID As Integer
    Public ParentID As Integer
    Public NodeText As String

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ID"></param>
    ''' <param name="ParentID"></param>
    ''' <param name="NodeText"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal ID As Integer, ByVal ParentID As Integer, ByVal NodeText As String)
        Me.ID = ID
        Me.ParentID = ParentID
        Me.NodeText = NodeText
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Return Me.NodeText
    End Function
End Class