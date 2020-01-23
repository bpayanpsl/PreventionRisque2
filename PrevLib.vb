Imports System.Data.SqlClient

Module PrevLib
    Public Const connectionString As String = "Data Source=serveur_silog;Initial Catalog=SRI;User ID=sa;Password="
    Public con As New SqlConnection(connectionString)
    Public identifiant As String
    Public societe As String

    Public tabRisques = New String(18, 0) {
        {"Risques d’incendie d’explosion"},
        {"Risques de violence au travail, d’agression"},
        {"Risques liés à l’éclairage"},
        {"Risques liés à l’énergie : électricité, gaz, air comprimé"},
        {"Risques liés à l’organisation du travail"},
        {"Risques liés à l’utilisation de machines"},
        {"Risques liés à la conduite (risque routier professionnel)"},
        {"Risques liés à la manutention manuelle, à la posture ou au geste répétitif"},
        {"Risques liés à la manutention mécanique"},
        {"Risques liés au bruit"},
        {"Risques liés au travail isolé"},
        {"Risques liés au travail par de fortes chaleurs"},
        {"Risques liés au travail sur écran"},
        {"Risques liés aux agents infectieux"},
        {"Risques liés aux ambiances thermiques (chaude ou froide)"},
        {"Risques liés aux chutes : de hauteur, de plain-pied"},
        {"Risques liés aux chutes d’objet"},
        {"Risques liés aux produits chimiques"},
        {"Risques liés aux rayonnements"}
    }
    Public TabRisquesLigne As Integer = 19

    Public tabProcessus = New String(16, 0) {
        {"Achat"},
        {"Administration/Comptabilité"},
        {"ADV"},
        {"BE"},
        {"Chargé affaire"},
        {"Commercial"},
        {"Commercial"},
        {"Expédition"},
        {"Informatique"},
        {"Magasin/Controle"},
        {"Montage"},
        {"Motorisation/Equipement"},
        {"Ordonnancement"},
        {"Peinture"},
        {"Soudage"},
        {"Test"},
        {"Usinage"}
    }
    Public tabProcessusLigne As Integer = 17
End Module
