using System.IO;
using System.Text;
using System.Collections.Generic;

public static class Horaires
{
    public static Dictionary<int, List<string>> lorientGroix = new Dictionary<int, List<string>>
    {
        { 1, new List<string> { "09:45", "12:15", "17:00", "19:30" } },
        { 2, new List<string> { "09:45", "12:15", "17:00", "19:30" } },
        { 3, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 4, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 5, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 6, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 7, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 8, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 9, new List<string> { "09:45", "12:15", "17:00", "19:30" } },
        { 10, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 11, new List<string> { "09:45", "12:15", "17:00", "19:30" } },
        { 12, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 13, new List<string> { "08:05", "11:00", "13:45", "18:45" } },
        { 14, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 15, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 16, new List<string> { "09:45", "12:15", "17:00", "19:30" } },
        { 17, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 18, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 19, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 20, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 21, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 22, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 23, new List<string> { "09:45", "12:15", "17:00", "19:30" } },
        { 24, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 25, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 26, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 27, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 28, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 29, new List<string> { "08:05", "11:00", "13:45", "16:15", "18:45" } },
        { 30, new List<string> { "09:45", "12:15", "17:00", "19:30" } }
    };

    public static Dictionary<int, List<string>> groixLorient = new Dictionary<int, List<string>>
    {
        { 1, new List<string> { "08:30", "11:00", "15:45", "18:15" } },
        { 2, new List<string> { "08:30", "11:00", "15:45", "18:15" } },
        { 3, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 4, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 5, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 6, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 7, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 8, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 9, new List<string> { "08:30", "11:00", "15:45", "18:15" } },
        { 10, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 11, new List<string> { "08:30", "11:00", "15:45", "18:15" } },
        { 12, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 13, new List<string> { "06:50", "12:30", "15:00", "17:30" } },
        { 14, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 15, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 16, new List<string> { "08:30", "11:00", "15:45", "18:15" } },
        { 17, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 18, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 19, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 20, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 21, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 22, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 23, new List<string> { "08:30", "11:00", "15:45", "18:15" } },
        { 24, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 25, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 26, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 27, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 28, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 29, new List<string> { "06:50", "09:30", "12:30", "15:00", "17:30" } },
        { 30, new List<string> { "08:30", "11:00", "15:45", "18:15" } }
    };

    public static Dictionary<int, List<string>> quiberonLePalais = new Dictionary<int, List<string>>
    {
        { 1, new List<string> { "08:15", "09:30", "11:15", "12:45", "14:45", "17:15", "19:00", "20:00" } },
        { 2, new List<string> { "08:00", "09:30", "11:15", "12:30", "14:15", "15:45", "17:15", "19:00", "20:00" } },
        { 3, new List<string> { "08:00", "09:30", "11:15", "14:30", "17:30", "19:30" } },
        { 4, new List<string> { "07:30", "09:30", "10:30", "13:30", "18:15", "19:30" } },
        { 5, new List<string> { "08:00", "10:30", "12:00", "17:15", "19:00", "20:00" } },
        { 6, new List<string> { "07:30", "08:30", "11:45", "14:45", "17:30", "19:45" } },
        { 7, new List<string> { "08:00", "09:30", "12:30", "15:30", "18:15", "20:00" } },
        { 8, new List<string> { "08:15", "09:45", "11:00", "14:15", "17:15", "19:30" } },
        { 9, new List<string> { "08:30", "11:15", "14:15", "16:15", "17:30", "19:30" } },
        { 10, new List<string> { "08:00", "09:30", "11:15", "14:15", "17:30", "19:30" } },
        { 11, new List<string> { "08:15", "11:15", "14:15", "16:15", "17:30", "19:30" } },
        { 12, new List<string> { "08:00", "09:30", "11:15", "14:15", "16:15", "17:15", "20:00" } },
        { 13, new List<string> { "08:00", "09:30", "11:15", "14:15", "17:15", "20:00", "20:00" } },
        { 14, new List<string> { "08:00", "09:30", "11:15", "14:15", "17:15", "19:15", "20:15" } },
        { 15, new List<string> { "08:00", "09:30", "11:15", "14:15", "17:30", "19:30" } },
        { 16, new List<string> { "08:15", "11:15", "14:15", "16:15", "17:15", "19:30" } },
        { 17, new List<string> { "08:00", "09:30", "11:15", "14:15", "16:15", "17:15", "20:00" } },
        { 18, new List<string> { "08:00", "09:30", "11:15", "14:15", "16:15", "17:15", "20:00" } },
        { 19, new List<string> { "08:00", "09:30", "11:15", "14:15", "17:15", "20:00", "20:00" } },
        { 20, new List<string> { "08:00", "09:30", "11:15", "14:15", "17:15", "20:00", "20:00" } },
        { 21, new List<string> { "08:00", "09:30", "11:15", "14:15", "17:15", "20:00", "20:15" } },
        { 22, new List<string> { "08:00", "09:30", "11:15", "14:15", "17:30", "19:30" } },
        { 23, new List<string> { "08:15", "11:15", "14:15", "16:15", "17:30", "19:30" } },
        { 24, new List<string> { "08:00", "09:30", "11:15", "14:15", "16:15", "17:15", "20:00" } },
        { 25, new List<string> { "08:00", "09:30", "11:15", "14:15", "16:15", "17:15", "20:00" } },
        { 26, new List<string> { "08:00", "09:30", "11:15", "14:15", "16:15", "17:15", "20:00" } },
        { 27, new List<string> { "08:00", "09:30", "11:15", "14:15", "16:15", "17:15", "20:00" } },
        { 28, new List<string> { "08:00", "09:30", "11:15", "14:15", "17:15", "19:15", "20:15" } },
        { 29, new List<string> { "08:00", "09:30", "11:15", "14:15", "17:30", "19:30" } },
        { 30, new List<string> { "08:15", "11:15", "14:15", "16:15", "17:30", "19:30" } }
    };

    public static Dictionary<int, List<string>> lePalaisQuiberon = new Dictionary<int, List<string>>
    {
        { 1, new List<string> { "06:45", "07:45", "09:45", "11:00", "12:45", "14:45", "17:30", "18:45" } },
        { 2, new List<string> { "06:30", "07:45", "09:45", "11:00", "12:45", "14:15", "15:45", "17:15", "18:40" } },
        { 3, new List<string> { "06:30", "07:45", "09:45", "12:45", "16:00", "18:00" } },
        { 4, new List<string> { "06:00", "07:45", "09:00", "12:00", "16:45", "18:00" } },
        { 5, new List<string> { "06:30", "07:45", "10:30", "13:30", "17:30", "18:30" } },
        { 6, new List<string> { "06:00", "07:00", "09:00", "13:15", "16:15", "18:30" } },
        { 7, new List<string> { "06:30", "07:45", "09:45", "12:45", "15:45", "18:45" } },
        { 8, new List<string> { "07:00", "08:00", "09:45", "12:45", "15:45", "17:45" } },
        { 9, new List<string> { "07:15", "09:45", "12:45", "14:45", "15:45", "18:00" } },
        { 10, new List<string> { "06:30", "07:45", "09:45", "12:45", "15:45", "18:00" } },
        { 11, new List<string> { "06:30", "07:45", "09:45", "12:45", "15:45", "18:00" } },
        { 12, new List<string> { "06:30", "07:45", "09:45", "12:45", "14:45", "15:45", "18:30" } },
        { 13, new List<string> { "06:30", "07:45", "09:45", "12:45", "14:45", "15:45", "18:30" } },
        { 14, new List<string> { "06:30", "07:45", "09:45", "12:45", "15:45", "17:45", "18:45" } },
        { 15, new List<string> { "06:30", "07:45", "09:45", "12:45", "15:45", "18:00" } },
        { 16, new List<string> { "06:30", "07:45", "09:45", "12:45", "15:45", "18:00" } },
        { 17, new List<string> { "06:30", "07:45", "09:45", "12:45", "14:45", "15:45", "18:30" } },
        { 18, new List<string> { "06:30", "07:45", "09:45", "12:45", "14:45", "15:45", "18:30" } },
        { 19, new List<string> { "06:30", "07:45", "09:45", "12:45", "14:45", "15:45", "18:30" } },
        { 20, new List<string> { "06:30", "07:45", "09:45", "12:45", "14:45", "15:45", "18:30" } },
        { 21, new List<string> { "06:30", "07:45", "09:45", "12:45", "15:45", "17:45", "18:45" } },
        { 22, new List<string> { "06:30", "07:45", "09:45", "12:45", "15:45", "18:00" } },
        { 23, new List<string> { "07:00", "09:45", "12:45", "14:45", "15:45", "18:00" } },
        { 24, new List<string> { "06:30", "07:45", "09:45", "12:45", "14:45", "15:45", "18:30" } },
        { 25, new List<string> { "06:30", "07:45", "09:45", "12:45", "14:45", "15:45", "18:30" } },
        { 26, new List<string> { "06:30", "07:45", "09:45", "12:45", "14:45", "15:45", "18:30" } },
        { 27, new List<string> { "06:30", "07:45", "09:45", "12:45", "14:45", "15:45", "18:30" } },
        { 28, new List<string> { "06:30", "07:45", "09:45", "12:45", "15:45", "17:45", "18:45" } },
        { 29, new List<string> { "06:30", "07:45", "09:45", "12:45", "15:45", "18:00" } },
        { 30, new List<string> { "07:00", "09:45", "12:45", "14:45", "15:45", "18:00" } }
    };
}

class CanReservation
{
    public static void AfficherListeHumain(List<string> liste)
    {
        System.Console.Write("|  ");
        for(int i=1; i <= liste.Count ;i++)
        {
            System.Console.Write(i+")"+liste[i-1] + "  |  ");
        }

        System.Console.Write("  |");
    }

    public static int IndiceLigneDe(string[,] tab, string cible)
    {
        for (int i = 0; i < tab.GetLength(0); i++)
        {
            if (tab[i, 0] == cible)
            {
                return i;
            }
        }

        return -1;
    }
    
    public struct Passager
    {
        public string nomDeFamille;
        public string prenom;
        public string categoriePassager;

        public static string[,] tarifsPassagers = new string[,]
        {
            { "adu26p", "18,75", "18,80" },
            { "jeu1825", "13,80", "14,10" },
            { "enf417", "11,25", "11,65" },
            { "bebe", "0", "0" },
            { "ancomp", "3,35", "3,35" }
        };

        public Passager(string nf, string pn, string ctP)
        {
            nomDeFamille = nf;
            prenom = pn;
            categoriePassager = ctP;
        }
    }
    
    public struct Vehicule
    {
        public string categorieVehicule;
        public int quantiteVehicule;

        public static string[,] tarifsVehicule = new string[,]
        {
            { "trot", "4,70", "4,70" }, { "velo", "8,20", "8,20" },
            { "velelec", "11,00", "11,00" }, { "cartand", "16,45", "16,45" },
            { "mobil", "23,10", "23,35" }, { "moto", "66,05", "66,40" },
            { "cat1", "96,05", "98,05" }, { "cat2", "114,80", "117,20" },
            { "cat3", "174,45", "176,90" }, { "cat4", "210,90", "213,35" },
            { "camp", "330,20", "332,70" }
        };

        public Vehicule(string catV, int quV)
        {
            categorieVehicule = catV;
            quantiteVehicule = quV;
        }
    }

    public struct Reservation
    {
        public string nomReservation;
        public int idLiaison;
        public int date;
        public string heure;
        public string horodatage;
        public static Dictionary<int, string> liaisons = new Dictionary<int, string>
        {
            { 1, "Lorient-Groix" }, { 2, "Groix-Lorient" }, { 3, "Quiberon-LePalais" }, { 4, "LePalais-Quiberon" }
        };
        
        public static string tarif(Reservation reservation)
        {
            if (reservation.idLiaison == 1 || reservation.idLiaison == 2)
            {
                return "groix";
            }
            else
            {
                return "belleile";
            }
        }

        public Reservation(string nR, int idLiai, int dt, string h)
        {
            nomReservation = nR;
            idLiaison = idLiai;
            date = dt;
            heure = h;
            System.DateTime maintenant = System.DateTime.Now;
            horodatage = maintenant.ToString("yyyy-MM-dd HH:mm:ss"); 

        }
    }

    public static double RecapitulatifCommande(Reservation reservation,
        List<Passager> listePassagers, List<Vehicule> listeVehicules)
    {
        System.Console.WriteLine("---------Recapitulatif de la commande----------");
        System.Console.WriteLine("------Réservation au nom de " + reservation.nomReservation + "-------");

        switch (reservation.idLiaison)
        {
            case 1:
                System.Console.WriteLine("Pour une traversée Lorient-Groix");
                break;

            case 2:
                System.Console.WriteLine("Pour une traversée Groix-Lorient");
                break;

            case 3:
                System.Console.WriteLine("Pour une traversée Quiberon-LePalais");
                break;

            case 4:
                System.Console.WriteLine("Pour une traversée LePalais-Quiberon");
                break;
        }
        System.Console.WriteLine("le " + "2025-11-" + reservation.date + " a " + reservation.heure);
        string lieu = Reservation.tarif(reservation);
        if(lieu == "groix")
        {
            System.Console.WriteLine("Le tarif appliqué sera le tarif Groix");
        }
        else
        {
            System.Console.WriteLine("Le tarif appliqué sera le tarif Belle ile");
        }

        System.Console.WriteLine("---------------Passagers-----------------");
        double prixVehicules = 0, prixPassagers = 0;

        for (int i = 0; i < listePassagers.Count; i++)
        {
            System.Console.WriteLine("Passager numéro " + (i+1) + " : " +
                listePassagers[i].nomDeFamille + " " + listePassagers[i].prenom +
                " de catégorie : " + listePassagers[i].categoriePassager);
            System.Console.Write("|------> Prix Unitaire : ");
            double prixPUnit;
            int indiceP = IndiceLigneDe(Passager.tarifsPassagers,listePassagers[i].categoriePassager);
            if (lieu == "groix")
            {
                prixPUnit = double.Parse(Passager.tarifsPassagers[indiceP,1]);
            }
            else
            {
                prixPUnit = double.Parse(Passager.tarifsPassagers[indiceP,2]);
            }
            
            System.Console.WriteLine(prixPUnit.ToString("0.00") + "€");
            prixPassagers += prixPUnit;
        }
        System.Console.WriteLine("Prix Total des Passagers : " + prixPassagers.ToString("0.00") + "€");
        System.Console.WriteLine("--------------Vehicules-----------------");

        for (int i = 0; i < listeVehicules.Count; i++)
        {
            System.Console.WriteLine(
                "Type de vehicule numéro " + (i+1) + " " +
                listeVehicules[i].categorieVehicule + " quantite : " +
                listeVehicules[i].quantiteVehicule
            );

            System.Console.Write("|------> Prix : " + listeVehicules[i].quantiteVehicule + " x ");
            double prixVunit;
            int indiceV = IndiceLigneDe(Vehicule.tarifsVehicule, listeVehicules[i].categorieVehicule); 
            if (lieu == "groix")
            {
                prixVunit = double.Parse(Vehicule.tarifsVehicule[indiceV,1]);
            }
            else
            {
                prixVunit = double.Parse(Vehicule.tarifsVehicule[indiceV,2]);
            }
            double prixVT = prixVunit * listeVehicules[i].quantiteVehicule;
            System.Console.WriteLine(prixVunit.ToString("0.00") + "€ = " + prixVT.ToString("0.00") + "€");

            prixVehicules += prixVT;
        }
        System.Console.WriteLine("Prix Total des Vehicules : " + prixVehicules.ToString("0.00") + "€");
        System.Console.WriteLine("-------------Prix reservation totale------------------");
        double prixTotal = prixVehicules + prixPassagers;
        System.Console.WriteLine("Le prix pour cette réservation est de : " + prixTotal.ToString("0.00") + "€");

        return prixTotal;
    }

    public static void GenererJson(List<Reservation> listeReservations, List<List<Passager>> toutesLesListesDePassagers,
                        List<List<Vehicule>> toutesLesListesDeVehicules)
    {
        FileStream fs = new FileStream("canReservation.json", FileMode.Create, FileAccess.Write);
        StreamWriter fichierJson = new StreamWriter(fs);

        fichierJson.WriteLine("[");

        for (int i = 0; i < listeReservations.Count; i++)
        {
            List<Passager> passagersCourants = toutesLesListesDePassagers[i];
            List<Vehicule> vehiculesCourants = toutesLesListesDeVehicules[i];

            fichierJson.WriteLine("{");
            fichierJson.WriteLine("\"reservation\" :");
            fichierJson.WriteLine("{");
            fichierJson.WriteLine("\"nom\": " + "\"" + listeReservations[i].nomReservation + "\",");
            fichierJson.WriteLine("\"idLiaison\": " + listeReservations[i].idLiaison + ",");
            if ((int)listeReservations[i].date < 10) //afficher le 0 ou non
            {
                fichierJson.WriteLine("\"date\": " + "\"" + "2025-11-0" + listeReservations[i].date + "\",");
            }
            else
            {
                fichierJson.WriteLine("\"date\": " + "\"" + "2025-11-" + listeReservations[i].date + "\",");
            }

            fichierJson.WriteLine("\"heure\": " + "\"" + listeReservations[i].heure + "\",");
            fichierJson.WriteLine("\"horodatage\": " + "\"" + listeReservations[i].horodatage+ "\"");
            fichierJson.WriteLine("}");
            fichierJson.WriteLine(",");

            fichierJson.WriteLine("\"passagers\": [");
            for (int p = 0; p < passagersCourants.Count; p++)
            {
                fichierJson.WriteLine("{");
                fichierJson.WriteLine("\"nom\": " + "\"" + passagersCourants[p].nomDeFamille + "\",");
                fichierJson.WriteLine("\"prenom\": " + "\"" + passagersCourants[p].prenom + "\",");
                fichierJson.WriteLine("\"codeCategorie\": " + "\"" + passagersCourants[p].categoriePassager + "\"");
                fichierJson.WriteLine("}");

                if (p < passagersCourants.Count - 1)
                {
                    fichierJson.WriteLine(",");
                }
            }

            fichierJson.WriteLine("],");

            fichierJson.WriteLine("\"vehicules\": [");
            for (int v = 0; v < vehiculesCourants.Count; v++)
            {
                fichierJson.WriteLine("{");
                fichierJson.WriteLine("\"codeCategorie\": " + "\"" + vehiculesCourants[v].categorieVehicule + "\",");
                fichierJson.WriteLine("\"quantite\": " + vehiculesCourants[v].quantiteVehicule);
                fichierJson.WriteLine("}");

                if (v < vehiculesCourants.Count - 1)
                {
                    fichierJson.WriteLine(",");
                }
            }

            fichierJson.WriteLine("]");

            fichierJson.WriteLine("}");

            if (i < listeReservations.Count - 1)
            {
                fichierJson.WriteLine(",");
            }
        }

        fichierJson.WriteLine("]");
        fichierJson.Close();
        System.Console.WriteLine("------------Json-----------");
        System.Console.WriteLine("Fichier JSON de la réservation généré ! :D");
    }
    
    public static void Main()
    {
        System.Console.OutputEncoding = Encoding.UTF8;
        System.Console.InputEncoding = Encoding.UTF8;//que ca affiche des bons characteres au lieu des ?

        int choixTraversee, choixDate, choixHeure, choixCat, nbReservations;
        double prixFinal = 0;
        string nomReservation;
        List<Reservation> listeTotaleReservations = new List<Reservation>();
        //liste de liste : chaque réservation a sa propre liste de passagers et de véhicules
        List<List<Passager>> listeTotalePersonnes = new List<List<Passager>>();
        List<List<Vehicule>> listeTotaleVehicules = new List<List<Vehicule>>();

        System.Console.WriteLine(@"   _________    _   __
  / ____/   |  / | / /
 / /   / /| | /  |/ / 
/ /___/ ___ |/ /|  /  
\____/_/  |_/_/ |_/   
                      "); //logo avec @ pour les \
        System.Console.WriteLine("Bienvenue dans le logiciel de réservation de la CAN ! ");
        System.Console.WriteLine("---------------------------");
        System.Console.WriteLine("Combien de réservations allez-vous faire sans compter les trajets retour ?");
        nbReservations = int.Parse(System.Console.ReadLine());

        for (int rese = 1; rese <= nbReservations; rese++)
        {
            List<Passager> listePersonnes = new List<Passager>();
            List<Vehicule> listeVehicules = new List<Vehicule>();
            Reservation reservationPrincipale = new Reservation();
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("Gestion de la réservation numéro " + rese + " !");
            System.Console.WriteLine("--------------------------");
            do
            {
                System.Console.WriteLine("Choisissez votre traversée ! ");
                System.Console.WriteLine("1) Lorient - Groix ");
                System.Console.WriteLine("2) Groix - Lorient ");
                System.Console.WriteLine("3) Quiberon - Le Palais ");
                System.Console.WriteLine("4) Le Palais - Quiberon ");
                choixTraversee = int.Parse(System.Console.ReadLine());
            } while (choixTraversee < 1 || choixTraversee > 4);

            System.Console.WriteLine("Il faut maintenant choisir un jour du mois de novembre 2025");
            do
            {
                System.Console.WriteLine("Choisissez un jour de 1 à 30 de novembre");
                choixDate = int.Parse(System.Console.ReadLine());

            } while (choixDate < 1 || choixDate > 30);

            List<string> heuresDispo = new List<string>();
            System.Console.WriteLine("Pour cette date, Les heures suivantes disponibles sont : ");
            do
            {
                switch (choixTraversee)
                {
                    case 1:
                        heuresDispo = Horaires.lorientGroix[choixDate];
                        break;
                    case 2:
                        heuresDispo = Horaires.groixLorient[choixDate];
                        break;
                    case 3:
                        heuresDispo = Horaires.quiberonLePalais[choixDate];
                        break;
                    case 4:
                        heuresDispo = Horaires.lePalaisQuiberon[choixDate];
                        break;
                }

                AfficherListeHumain(heuresDispo);
                System.Console.WriteLine("Choisissez le numéro de l'heure convenue");
                choixHeure = int.Parse(System.Console.ReadLine());
            } while (choixHeure < 1 || choixHeure > heuresDispo.Count);

            System.Console.WriteLine("Quel sera le nom de la réservation ?");
            nomReservation = System.Console.ReadLine();

            reservationPrincipale =
                new Reservation(nomReservation, choixTraversee, choixDate, heuresDispo[choixHeure - 1]);
            
            int nbPersonnes;
            do
            {
                System.Console.WriteLine("Combien de Personnes voyagerons ? : ");
                nbPersonnes = int.Parse(System.Console.ReadLine());

            } while (nbPersonnes < 1); // pas < 0 sinon a quoi bon voyager ?
            
            Passager passagerCourant;
            string nomCourant, prenomCourant;
            for (int i = 1; i <= nbPersonnes; i++)
            {
                System.Console.WriteLine("Enregistrement pour la personne numéro " + i);
                System.Console.WriteLine("Quel est son prenom ?");
                prenomCourant = System.Console.ReadLine();
                System.Console.WriteLine("Quel est le nom de famille de " + prenomCourant);
                nomCourant = System.Console.ReadLine();
                System.Console.WriteLine("Determinons maintenant la catégorie de " + nomCourant +
                                         " " + prenomCourant);
                do
                {
                    System.Console.WriteLine("Choisissez la catégorie : ");
                    System.Console.WriteLine("1) Adulte de 26 ans et plus");
                    System.Console.WriteLine("2) Jeune de 18 ans jusqu'à 25 ans inclus");
                    System.Console.WriteLine("3) Enfant de 4 à 17 ans inclus");
                    System.Console.WriteLine("4) Bébé de moins de 4 ans");
                    System.Console.WriteLine("5) Animal de compagnie");
                    System.Console.Write("Votre choix : ");
                    choixCat = int.Parse(System.Console.ReadLine());

                } while (choixCat < 1 || choixCat > 5);

                passagerCourant = new Passager(nomCourant, prenomCourant, Passager.tarifsPassagers[choixCat - 1, 0]);
                listePersonnes.Add(passagerCourant);
            }

            int nbVehicules = 0;
            System.Console.WriteLine("Interessons nous aux véhicules maintenant.");
            do
            {
                System.Console.WriteLine("Combien y'aura-il de types différents de véhicules pour le voyage ? : ");
                nbVehicules = int.Parse(System.Console.ReadLine());

            } while (nbVehicules < 0);
            
            Vehicule vehiculeCourant;
            string categorieCouranteVeh = "";
            int quantiteCourante;
            for (int i = 1; i <= nbVehicules; i++)
            {
                System.Console.WriteLine("Quel est le type du véhicule actuel ? ");
                int catV;
                do
                {
                    System.Console.WriteLine("1) Trottinette électrique");
                    System.Console.WriteLine("2) Vélo ou remorque à vélo");
                    System.Console.WriteLine("3) Vélo électrique");
                    System.Console.WriteLine("4) Vélo cargo ou tandem");
                    System.Console.WriteLine("5) Deux-roues <= 125 cm3");
                    System.Console.WriteLine("6) Deux-roues > 125 cm3");
                    System.Console.WriteLine("7) Voiture moins de 4 m");
                    System.Console.WriteLine("8) Voiture de 4 m à 4.39 m");
                    System.Console.WriteLine("9) Voiture de 4.40 m à 4.79 m");
                    System.Console.WriteLine("10) Voiture 4.80 m et plus");
                    System.Console.WriteLine("11) Camping-car - véhicule plus de 2.10 m de haut");

                    catV = int.Parse(System.Console.ReadLine());
                } while (catV < 1 || catV > 11);

                categorieCouranteVeh = Vehicule.tarifsVehicule[catV - 1, 0];
                do
                {
                    System.Console.WriteLine("Combien de fois ce modèle sera-il présent ? ");
                    quantiteCourante = int.Parse(System.Console.ReadLine());
                } while (quantiteCourante < 1); //logique

                vehiculeCourant = new Vehicule(categorieCouranteVeh, quantiteCourante);
                listeVehicules.Add(vehiculeCourant);
            }

            System.Console.WriteLine("Recapitulatif réservation ---- " + rese);
            double prixReservation = RecapitulatifCommande(reservationPrincipale, listePersonnes, listeVehicules);
            //le trajet retour est sans doute le jour suivant
            double prixRetour = 0, prixTotal = 0;
            string choixRetour;
            Reservation reservationRetour = new Reservation();
            listeTotaleReservations.Add(reservationPrincipale);
            listeTotalePersonnes.Add(listePersonnes);
            listeTotaleVehicules.Add(listeVehicules);
            if (reservationPrincipale.date < 30) // on peut pas faire le jour suivant si c'est fin du mois
            {
                System.Console.WriteLine("Souhaitez-vous ajouter à votre commande le trajet retour ?");
                do
                {
                    System.Console.WriteLine("Tapez 'non' ou 'oui' : ");
                    choixRetour = System.Console.ReadLine();
                } while (choixRetour != "non" && choixRetour != "oui");

                if (choixRetour == "oui")
                {
                    int jourSuivant = reservationPrincipale.date + 1;
                    switch (reservationPrincipale.idLiaison)
                    {
                        case 1: //l'heure du retour sera la premiere heure disponible du jour suivant de la traversée asociée
                            reservationRetour = new Reservation(reservationPrincipale.nomReservation + " retour", 2,
                                jourSuivant, Horaires.groixLorient[jourSuivant][0]);
                            break;

                        case 2:
                            reservationRetour = new Reservation(reservationPrincipale.nomReservation + " retour", 1,
                                jourSuivant, Horaires.lorientGroix[jourSuivant][0]);
                            break;

                        case 3:
                            reservationRetour = new Reservation(reservationPrincipale.nomReservation + " retour", 4,
                                jourSuivant, Horaires.lePalaisQuiberon[jourSuivant][0]);
                            break;

                        case 4:
                            reservationRetour = new Reservation(reservationPrincipale.nomReservation + " retour", 3,
                                jourSuivant, Horaires.quiberonLePalais[jourSuivant][0]);
                            break;
                    }

                    listeTotaleReservations.Add(reservationRetour);
                    listeTotalePersonnes.Add(listePersonnes);
                    listeTotaleVehicules.Add(listeVehicules);
                    prixRetour = RecapitulatifCommande(reservationRetour, listePersonnes, listeVehicules);
                    prixTotal = prixReservation + prixRetour;
                    prixFinal += prixTotal;

                    System.Console.WriteLine("------------Prix Total de la réservation " + rese +
                                             " : -------------");
                    System.Console.WriteLine("Ainsi le prix Total de la commande est de : " +
                                             prixTotal.ToString("0.00") +
                                             "€");
                }
            }
        }

        System.Console.WriteLine(
            "-----------------Prix Final de toutes les réservations (avec trajets-retours si inclus)+" +
            "-----------------");
        System.Console.WriteLine("Pour " + nbReservations + " réservations avec trajets retour si choisis : ");
        System.Console.WriteLine("--> " + prixFinal.ToString("0.00") + "€");

        GenererJson(listeTotaleReservations, listeTotalePersonnes, listeTotaleVehicules);
    }
}
