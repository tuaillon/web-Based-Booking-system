const lienAPI = "https://can.iutrs.unistra.fr/api/reservation/";
//facture bouton
const btnFacture = document.getElementById("btnFacture").addEventListener("click",
     () => {
    window.print(); //imprimer
});

//verifife si un mot est dans un dictionnaire
const estDansMap = (uneMap, mot ) =>
{
    for (const key of uneMap.keys()) {
        if (key === mot) {
            return true;
        }
    }
    return false;
}

//remplir la page avec les données
document.getElementById("btnSendRes").addEventListener("click", async () => 
    {
    const idRes = document.getElementById("resIdChoix").value;
    console.log("ID de réservation choisi :", idRes);
    //réinitialisation des champs (-_-)
    document.getElementById("numReservation").textContent = "Numéro de réservation : ";
    document.getElementById("nomReservation").textContent = "Nom de la réservation : ";
    document.getElementById("traversee").textContent = "Traversée : ";
    document.getElementById("dateReservation").textContent = "Date de la réservation : ";
    document.getElementById("hDepart").textContent = "Heure de départ : ";
    document.getElementById("nomBateau").textContent = "Nom du bateau : ";

    document.getElementById("tabPassagers").innerHTML = "<tr><th>Catégorie</th><th>Nombre</th><th>Prix Unitaire (€)</th><th>Total (€)</th></tr>";
    document.getElementById("tabVehicules").innerHTML = "<tr><th>Catégorie</th><th>Nombre</th><th>Prix Unitaire (€)</th><th>Total (€)</th></tr>";

    document.getElementById("totPersonne").textContent = "Total Passagers : ";
    document.getElementById("totVehicule").textContent = "Total Véhicules : ";
    document.getElementById("totalPrix").textContent = "Prix Total : ";
    let data; // on déclare data
    try {
        const reponse = await fetch(`${lienAPI}${idRes}`);
        if (!reponse.ok) {
            throw new Error("Erreur lors de la récup des données");
        }
        data = await reponse.json();
    }
    catch (error) {
        console.log(error);
    }
    //remplissage des infos
    document.getElementById("numReservation").textContent += data.id;
    document.getElementById("nomReservation").textContent += data.nom;
    document.getElementById("traversee").textContent += data.portDepart + " -> " + data.portArrivee;
    document.getElementById("dateReservation").textContent += data.date;
    document.getElementById("hDepart").textContent += data.heure;
    document.getElementById("nomBateau").textContent += data.bateau;

    let prixTotal = 0;
    let prixPassager = 0;
    let prixVehicule = 0;
    let categories = new Map(); // clé: catégorie, valeur: prix
    let nbPassagers = new Map(); // clé: catégorie, valeur: nombre de passagers

    const tableauPassagers = document.getElementById("tabPassagers");
    //on parcourt les passagers
    for(let i=1; i<=data.nbPassagers; i++){
        try {
            const reponse = await fetch(`${lienAPI}${idRes}/passager/${i}`);
            if (!reponse.ok) {
                throw new Error("Erreur lors de la récup des passagers");
            }
            const passager = await reponse.json();
            //si la categorie n'est pas dans le dico on l'ajoute
            if(!estDansMap(categories, passager.libelleCategorie)){
                categories.set(passager.libelleCategorie, passager.price);
                nbPassagers.set(passager.libelleCategorie, 1);
            }
            else{
                nbPassagers.set(passager.libelleCategorie, nbPassagers.get(passager.libelleCategorie) + 1);//++
        }}
        catch (error) {
            console.log(error);
        }

    }
    //on parcourt le dico des passagers pour remplir le tableau
    for (const [categorie, nombre] of nbPassagers.entries()) {
        if (nombre > 0) {
            const prixUnitaire = categories.get(categorie);
            const ligne = document.createElement("tr");//création ligne
            ligne.innerHTML = `<td>${categorie}</td><td>${nombre}</td><td>${prixUnitaire.toFixed(2)}</td><td>${(nombre * prixUnitaire).toFixed(2)}</td>`;
            tableauPassagers.appendChild(ligne);
            prixPassager += nombre * prixUnitaire; //calcul du prix total des passagers
        }
    }

    document.getElementById("totPersonne").textContent = `${prixPassager.toFixed(2)} €`;
    
    let categoriesVehicule = new Map(); // clé: catégorie, valeur: prix
    let nbVehicules = new Map(); // clé: catégorie, valeur: nombre de véhicules

    const tableauVehicules = document.getElementById("tabVehicules");
    //meme chose pour les vehicules
    for(let j=1; j<=data.nbVehicules; j++){
        try {
            const reponse = await fetch(`${lienAPI}${idRes}/vehicule/${j}`);
            if (!reponse.ok) {
                throw new Error("Erreur lors de la récup des véhicules");
            }
            const vehicule = await reponse.json();
            //pas besoin de verifier car l'api donne deja la quantite
            categoriesVehicule.set(vehicule.libelle, vehicule.prix);
            nbVehicules.set(vehicule.libelle, vehicule.quantite);

        }
        catch (error) {
            console.log(error);
        }
    }

    for (const [categorie, nombre] of nbVehicules.entries()) {
        if (nombre >0) {
            const prixUnitaire = categoriesVehicule.get(categorie);
            const ligne = document.createElement("tr");//création ligne
            ligne.innerHTML = `<td>${categorie}</td><td>${nombre}</td><td>${prixUnitaire.toFixed(2)}</td><td>${(nombre * prixUnitaire).toFixed(2)}</td>`;
            tableauVehicules.appendChild(ligne);
            prixVehicule += nombre * prixUnitaire;
        }
    }

    document.getElementById("totVehicule").textContent = `${prixVehicule.toFixed(2)} €`;
    //prix total
    prixTotal = prixPassager + prixVehicule;
    document.getElementById("totalPrix").textContent = `${prixTotal.toFixed(2)} €`;
});
