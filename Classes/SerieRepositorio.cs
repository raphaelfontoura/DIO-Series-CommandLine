using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private static List<Serie> listaSerie = new List<Serie>();
        public List<Serie> Lista()
        {
            return listaSerie;
        }
        
        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Excluir(int id)
        {
            listaSerie[id].excluir();
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

    }
}