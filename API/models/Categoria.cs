using System;

namespace API.models
{
    public class Categoria
    {
        public Categoria() => CriadoEm = DateTime.Now;

        public int Id { get; set; }
        public string Nome { get; set;}
        public DateTime CriadoEm { get; set; }
    }
}