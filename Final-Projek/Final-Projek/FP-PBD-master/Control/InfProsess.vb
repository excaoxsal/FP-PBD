﻿Imports System.Data.OleDb

Public Interface InfProsess
    Function InsertData(Ob As Object) As OleDbCommand
    Function updateData(Ob As Object) As OleDbCommand
    Function deleteData(Ob As Object) As OleDbCommand
    Function tampilData() As DataView
    Function cariData(kunci As String) As DataView
End Interface