namespace ComparadorSchema;

public class TabelaSchema
{
    public string Column_Name { get; set; } = string.Empty;
    public string Data_Type { get; set; } = string.Empty;
    public string Is_Nullable { get; set; } = string.Empty;
    public string Column_Key { get; set; } = string.Empty;
    public string Column_Default { get; set; } = string.Empty;
    public string Extra { get; set; } = string.Empty;
}
