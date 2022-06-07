Imports System.Data.OleDb
Imports System.IO
Module Cnxdb

    Public cmd As OleDb.OleDbCommand
    Public cnx As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\amasi\Desktop\PFE\VS 2010\Bulletien_De_Paie\Bulletien_De_Paie\employee_db.accdb;User ID=Admin;Jet OLEDB:Encrypt Database=True;Jet OLEDB:Database Password=1234")
    'Public cnx As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="C:\Users\amasi\Desktop\PFE\VS 2010\Bulletien_De_Paie\Bulletien_De_Paie\employee_db.accdb";Persist Security Info=True")
End Module
