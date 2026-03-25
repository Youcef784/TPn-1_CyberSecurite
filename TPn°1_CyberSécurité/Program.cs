using TPn_1_CyberSécurité;

// Utilisateur
Utilisateur u1 = new Utilisateur(new DateTime(2026, 3, 23,21, 43, 07), "toto@libre.fr", 1, "hash123", "Alice", 1);
// ProfilSecurite
ProfilSecurite p1 = new ProfilSecurite(1, false, new DateTime(2026, 3, 23, 21, 43, 07), "21/03/2024", true, 2, 5);
Console.WriteLine(u1.ToString());
Console.WriteLine(p1.ToString());