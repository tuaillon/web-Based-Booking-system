const lienAPI = "https://can.iutrs.unistra.fr/api/liaison/";

//aurait pu etre récupérée avec requete
const liaisons = ["Lorient-Groix", "Groix-Lorient", 
    "Quiberon-Le Palais", "Le Palais-Quiberon"];

//liste pour les id des articles dans le html
const idArticles = ["lg", "gl", "qp", "pq"];
let caTotal = 0;

(async () => {
    for(let i=1; i<=4; i++){
        const article = document.getElementById(idArticles[i-1]); //récupérer l'article correspondant
        const detailsLiaison = document.createElement("ul"); //liste non ordonnée
        
        try {
            const reponse = await fetch(`${lienAPI}${i}/chiffreAffaire`);
        if (!reponse.ok) {
            throw new Error("Erreur lors de la récup des données");
        }
        const data = await reponse.json();
        let caActuel = data.passagers.chiffreAffaire + data.vehicules.chiffreAffaire;
        caTotal += caActuel;
        detailsLiaison.innerHTML = `
            <li> Chiffre d'affaires : ${caActuel.toFixed(2)} €</li>
            <li> Nombre de Passagers : ${data.passagers.nombre}</li>
            <li> Nombre de Véhicules : ${data.vehicules.quantite}</li>
        `;
        article.appendChild(detailsLiaison);
        } catch (error) {
            console.log(error);
        }
    }
    const totalElement = document.getElementById("total"); //total
    totalElement.textContent = `Chiffre d'affaires total : ${caTotal.toFixed(2)} €`;
})(); //fonction qui s'auto-exécute