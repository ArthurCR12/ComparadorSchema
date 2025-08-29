namespace ComparadorSchema.Classes;

public class MsgHandler
{
    private static readonly string LogPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ComparadorSchema", "logs");

    static MsgHandler()
    {
        if (!Directory.Exists(LogPath))
            Directory.CreateDirectory(LogPath);
    }

    public static bool Question(string mensagem)
    {
        var result = MessageBox.Show(mensagem, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        Log("QUESTION", $"{mensagem} - Resposta: {result}");
        return result == DialogResult.Yes;
    }

    public static void Warning(string mensagem)
    {
        MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        Log("WARN", mensagem);
    }

    public static void Erro(string mensagem)
    {
        MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Log("ERROR", mensagem);
    }

    public static void Success(string mensagem) 
    {
        MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Log("SUCESS", mensagem);
    }

    public static void Info(string mensagem)
    {
        MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Log("INFO", mensagem);
    }

    private static void Log(string nivel, string mensagem)
    {
        try
        {
            var logFileName = $"log_{DateTime.Now:ddMMyyyy}.txt";
            var logFilePath = Path.Combine(LogPath, logFileName);
            var logEntry = $"[{DateTime.Now:dd-MM-yyyy HH:mm:ss}] [{nivel}] {mensagem}{Environment.NewLine}";

            File.AppendAllText(logFilePath, logEntry);
        }
        catch (Exception)
        {
        }
    }

    public static void LogExcecao(Exception ex, string contexto = "")
    {
        var mensagem = $"Ex em {contexto}: {ex.Message}";
        if (ex.InnerException != null) mensagem += $" | Inner: {ex.InnerException.Message}";

        Log("EXCEPTION", $"{mensagem} | StackTrace: {ex.StackTrace}");
    }
}
