using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EvolutionalAlgorithmsExample.Core
{
    public class Genome
    {
        public Nucleotide[] nucleotides;

        public Genome(GenomeSchema[] genomeSchemas)
        {
            nucleotides = new Nucleotide[genomeSchemas.Length];
            for (int i = 0; i < genomeSchemas.Length; i++)
            {
                nucleotides[i] = genomeSchemas[i].CreateNewNucleotide();
            }
        }

        private Genome(Genome src)
        {
            nucleotides = new Nucleotide[src.nucleotides.Length];
        }


        public void Mutate(double probability)
        {
            foreach (Nucleotide temp in nucleotides)
            {
                temp.Mutate(probability);
            }
        }

        private void Randomize()
        {
            
        }





        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Nucleotide temp in nucleotides)
            {
                sb.Append(temp.ToString());

            }

            return sb.ToString();
        }


        public Genome Copy()
        {
            Genome newGenome = new Genome(this);

            for (int i = 0; i < this.nucleotides.Length; i++)
            {
                newGenome.nucleotides[i] = this.nucleotides[i].Copy();
            }
            return newGenome;
        }
    }
}
