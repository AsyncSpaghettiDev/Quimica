using System;
    class Atomo{
        private String[] nivel = new String[] {"1s","2s","2p","3s","3p","4s","3d","4p","5s","4d","5p","6s","4f","5d","6p","7s","5f","6d","7p"};
        private int[] carga = new int[] {2,2,6,2,6,2,10,6,2,10,6,2,14,10,6,2,14,10,6};
        private int[] configElec = new int[19];
        public int getConfigElec(int i)=>configElec[i];
        public string getNivel(int i)=>nivel[i];
        public void confige(int e){
            for(int i=0;i<19;i++){
                if (e>=carga[i]){
                    configElec[i]=carga[i];
                    e=e-carga[i];
                }
                else{
                    configElec[i]=e;
                    break;
                }
            }
        }
    }
    class CargaEfectiva{
        private String[] grupos = new String[]{"1s","2s","2p","3s","3p","3d","4s","4p","4d","4f","5s","5p","5d","5f","6s","6p","6d","7s","7p"};
        private int[] electrones = new int[19];
        Atomo a1= new Atomo();
        public void ordenar(int e){
            a1.confige(e);
            for(int i=0;i<19;i++){
                switch (i){
                    case 5:
                    electrones[i]=a1.getConfigElec(6);
                    break;

                    case 6:
                    electrones[i]=a1.getConfigElec(5);
                    break;

                    case 8:
                    electrones[i]=a1.getConfigElec(9);
                    break;

                    case 9:
                    electrones[i]=a1.getConfigElec(12);
                    break;

                    case 10:
                    electrones[i]=a1.getConfigElec(8);
                    break;

                    case 11:
                    electrones[i]=a1.getConfigElec(10);
                    break;

                    case 12:
                    electrones[i]=a1.getConfigElec(13);
                    break;

                    case 13:
                    electrones[i]=a1.getConfigElec(16);
                    break;

                    case 14:
                    electrones[i]=a1.getConfigElec(11);
                    break;

                    case 15:
                    electrones[i]=a1.getConfigElec(14);
                    break;

                    case 16:
                    electrones[i]=a1.getConfigElec(17);
                    break;

                    case 17:
                    electrones[i]=a1.getConfigElec(15);
                    break;

                    default:
                    electrones[i]=a1.getConfigElec(i);
                    break;
                }
            }
        }
        public int getElectrones(int i)=>electrones[i];
        public string getGrupos(int i)=>grupos[i];
    }
    class Program{
        static void Main(){
            Atomo a1= new Atomo();
            CargaEfectiva c1=new CargaEfectiva();

            Console.Write("Número atómico: ");
            int e=Int32.Parse(Console.ReadLine());

            a1.confige(e);

            for(int i=0;i<19;i++){
                if(a1.getConfigElec(i)==0) break;
                Console.Write("{0}{1} ",a1.getNivel(i),a1.getConfigElec(i));
            }
            Console.WriteLine();

            c1.ordenar(e);

            for(int i=0;i<19;i++){
                Console.Write("{0}{1} ",c1.getGrupos(i),c1.getElectrones(i));
            }
            Console.WriteLine();
        }
    }