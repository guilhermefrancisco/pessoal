namespace Record_Types
{
    /* 
     * É um objeto de valor de dados imutável
     * A herança funciona aqui também! só não podemos herdar um record de qualquer outra classe não sendo object
     * Não podemos herdar uma classe de um record.
     * 
     * */

    public record Cliente
    {
        // init => se estiver numa classe, utilize -> init <- para fazer a propriedade ser imutável, e o restante não será
        public string Nome { get; init; }
        public string Sobrenome { get; init; }
        public string Email { get; init; }
    }
}
