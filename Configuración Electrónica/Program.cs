using System;
    class Atomo{
        private String[] nivel = new String[] {"1s","2s","2p","3s","3p","4s","3d","4p","5s","4d","5p","6s","4f","5d","6p","7s","5f","6d","7p"};
        private int[] carga = new int[] {2,2,6,2,6,2,10,6,2,10,6,2,14,10,6,2,14,10,6};
        private int[] cargae = new int[19];
        public int getCargae(int i)=>cargae[i];
        public string getNivel(int i)=>nivel[i];
        public void confige(int e){
            for(int i=0;i<19;i++){
                if (e>=carga[i]){
                    cargae[i]=carga[i];
                    e=e-carga[i];
                }
                else{
                    cargae[i]=e;
                    break;
                }
            }
        }
    }
    class Program{
        static void Main(){
            Atomo a1= new Atomo();
            Console.Write("Número atómico: ");
            int e=Int32.Parse(Console.ReadLine());

            a1.confige(e);

            for(int i=0;i<19;i++){
                if(a1.getCargae(i)==0) break;
                Console.Write("{0}{1} ",a1.getNivel(i),a1.getCargae(i));
            }
            Console.WriteLine();
        }
    }