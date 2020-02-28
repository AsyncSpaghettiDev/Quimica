using System;
    class Program{
        static String[] nivel = new String[] {"1s","2s","2p","3s","3p","4s","3d","4p","5s","4d","5p","6s","4f","5d","6p","7s","5f","6d","7p"};
        static int[] carga = new int[] {2,2,6,2,6,2,10,6,2,10,6,2,14,10,6,2,14,10,6};
        static int[] cargae = new int[19];
        static void confige(int e){
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
        static void Main(){
            Console.Write("Número atómico: ");
            int e=Int32.Parse(Console.ReadLine());

            confige(e);

            for(int i=0;i<19;i++){
                if(cargae[i]==0) break;
                Console.Write("{0}{1} ",nivel[i],cargae[i]);
            }
            Console.WriteLine();
        }
    }