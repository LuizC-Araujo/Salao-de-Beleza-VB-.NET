﻿Module Module1
    Public tent As Int32
    Public resp, diretorio, aux, cliente, cpfCliente, vetor(22), sql As String
    Public db, db2 As ADODB.Connection
    Public rs, rsAux, rs2 As ADODB.Recordset
    Public conexao = Application.StartupPath & "\bancos\dbSpaBeleza.mdb"
    Public drag, cpf, agenda, funcionario As Boolean
    Public mousex, mousey, cod, id As Integer
    Public d As Date

    Sub ConectaBanco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.jet.OLEDB.4.0;Data Source=" & conexao)
            'MsgBox("Conexão bem sucedida!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
            db2 = CreateObject("ADODB.Connection")
            db2.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\lj133\source\repos\SpaFreyaOficial\SpaFreyaOficial\dbSpaBeleza.mdb")
        Catch ex As Exception
            MsgBox("Conexão mal sucedida!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
    End Sub

    Public formularios As New Collection

    Sub ShowFormCliente()
        Dim NovoForm As New FrmControleCliente
        formularios.Add(NovoForm)
        NovoForm.Show()
    End Sub

    Sub ShowFormCep()
        Dim NovoForm As New FrmCep
        formularios.Add(NovoForm)
        NovoForm.Show()
    End Sub

    Sub ShowFormDgv()
        Dim NovoForm As New FrmShow
        formularios.Add(NovoForm)
        NovoForm.Show()
    End Sub

    Sub SHowFormAgendamento()
        Dim NovoForm As New FrmAgendamento
        formularios.Add(NovoForm)
        NovoForm.Show()
    End Sub

End Module
