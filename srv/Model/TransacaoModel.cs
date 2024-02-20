using System.ComponentModel.DataAnnotations;

namespace RinhaBachend2024q1.Model;

public class TransacaoModel
{
    [Required(ErrorMessage = "O campo Valor é obrigatório.")]
    [Range(1, int.MaxValue, ErrorMessage = "O campo Valor deve ser maior que zero.")]
    public int Valor {get; set;}

    [Required(ErrorMessage = "O campo Tipo é obrigatório.")]
    [TipoTransacao(ErrorMessage = "O campo Tipo deve ser 'd' ou 'c'.")]
    public string? Tipo {get; set;}

    [Required(ErrorMessage = "O campo Descricao é obrigatório.")]
    [StringLength(10, ErrorMessage = "Descrição não pode ser maior que 10 caracteres.")]
    public string? Descricao {get; set;}

}

public class TipoTransacaoAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        string? tipo = value as string;

        if (tipo != "d" && tipo != "c")
            return new ValidationResult("O campo Tipo deve ser 'd' ou 'c'.");

        return ValidationResult.Success;
    }
}