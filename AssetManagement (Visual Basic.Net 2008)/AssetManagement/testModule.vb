Module testModule
    Public Constr As String = Configuration.ConfigurationManager.ConnectionStrings("Connect").ConnectionString
    Public var As String
    Public item As String
    Public rptID As String
    Public DonorID As String
    Public rid As Integer
    Public uid As Integer
    Public DonorFlag As Boolean = False
    Public sel As Boolean = True
    Public UserType As String
End Module
