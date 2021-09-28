using System;

namespace API.models
{
    public class Automovel
    {
        //Construtor xd
        public int Id { get; set; }
        public Automovel() => CriadoEm = DateTime.Now;
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Placa { get; set; }

        public string Cor { get; set; }

        public DateTime CriadoEm { get; set; }

        public override string ToString() => $"Marca: { Marca } | Modelo: { Modelo } | Placa: { Placa } | Cor: { Cor } | Criado em: { CriadoEm }";
    }


}