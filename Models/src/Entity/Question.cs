namespace ASPNETMaker2024.Entities;

/**
 * Entity class for "Question" table
 */
[Table("Question")]
public class Question
{
    [Key("ID")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!;

    [Column("Question")]
    public string? _Question { get; set; }

    [Column("Answer")]
    public string? Answer { get; set; }

    [Column("Tag")]
    public string? Tag { get; set; }
}
