Module MYA_Interface

    Public ADB_Safelock As Boolean = False
    Public FB_Safelock As Boolean = False

    Public MYAStartupPath As String = Application.StartupPath
    Public MYA_tmppath As String = Environ("temp") + "\MYA"

    Public EXPLORER_NULL_STRING As String = "//NO_//DATA_//"
    Public EXPLORER_CORRUPTED_STRING As String = "//CORRUPTED_//DATA_//"

    Public ApplicationExecuted As Boolean = False
    Public MYALaunched As Boolean = False

    Public DefaultMYAFontName As String = "Segoe UI"

    Enum EXPLORER_CONTENT_TYPE

        Directory
        File
        Link
        None

    End Enum



    'DEBUG STUFF

    Public DbgLogSavePath As String =
        MYAStartupPath + "\__MYA_DEBUG_LOG__.txt"

    Public EnableDbgLogging As Boolean =
        True 'MUST DISABLE WHEN PUBLIC RELEASE

    Public EnableDbgLogSave As Boolean =
         False 'MUST DISABLE WHEN PUBLIC RELEASE

    Public EnableBetaChk As Boolean =
        False 'Test Feature

End Module
