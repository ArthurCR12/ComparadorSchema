namespace ComparadorSchema;

public class ForeignKeySchema
{
    public string Column_Name { get; set; } = string.Empty;
    public string Constraint_Name { get; set; } = string.Empty;
    public string Referenced_Table_Name { get; set; } = string.Empty;
    public string Referenced_Column_Name { get; set; } = string.Empty;
}
