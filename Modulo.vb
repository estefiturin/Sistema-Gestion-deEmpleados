Module Modulo

    Public Structure RegistroEmpleado
        Dim codigo As Integer
        Dim nombre As String
        Dim categoria As Integer
        Dim sueldo As Decimal

    End Structure

    'Declarar vector'
    Public empleado(100) As RegistroEmpleado

    'Declaro el indice'
    Public IND As Integer = 0



End Module
