Imports System.Data.OleDb
Imports System.IO
Module Cnxdb

    Public cmd As OleDb.OleDbCommand
    Public cnx As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\amasi\Desktop\PFE\VS 2010\Bulletien_De_Paie\Bulletien_De_Paie\database\employee_db.accdb")

End Module
