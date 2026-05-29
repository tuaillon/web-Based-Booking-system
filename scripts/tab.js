const lienAPI = "https://can.iutrs.unistra.fr/api/liaison/";

//fonction pour déterminer la couleur de remplissage
const couleurRemplissage = (taux) => {
    if (taux <= 50) {
        return "green";
    } else if (taux > 50 && taux <= 75) {
        return "orange";
    } else if (taux > 75 && taux <= 100) {
        return "red";
    } else {
        return "yellow";
    } 
}

const creerTableauBord = (date, liaison) =>
{
    (async () => {
        try {
            const reponse = await fetch(`${lienAPI}${liaison}/remplissage/${date}`);
            if (!reponse.ok) {
                console.error("Erreur lors de la récup des données");
            }
            const data = await reponse.json();
            console.log(data);
            let sectionTab = document.getElementById("infosTab");
            sectionTab.innerHTML = ""; // effacer le contenu précédent

            for(let i =0 ; i < data.length; i++)
            {
                const tauxRemplissagePassagers = data[i].nbReservationPassagers / data[i].capacitePassagers * 100;
                const tauxRemplissageVehicules = data[i].nbReservationVoitures / data[i].capaciteVoitures * 100;
                
                //article pour chaque traversée, prototype créé avant
                const article = document.createElement("article");
                article.innerHTML = `
                    <h3>Traversée à ${data[i].heure}</h3>
                    <p>Capacité passagers : ${data[i].capacitePassagers}</p>
                    <p>Nombre de passagers : ${data[i].nbReservationPassagers}</p>
                    <p>Capacité véhicules : ${data[i].capaciteVoitures}</p>
                    <p>Nombre de véhicules : ${data[i].nbReservationVoitures}</p>
                    <p>Taux de remplissage des passagers : ${tauxRemplissagePassagers.toFixed(2)}%</p>
                    <p style="color: ${couleurRemplissage(tauxRemplissageVehicules)};">Taux de remplissage des véhicules : ${tauxRemplissageVehicules.toFixed(2)}%</p>
                    <style> body main section {
                        display: flex;
                        flex-direction: column;
                        align-items: center;
                        justify-content: center;
                        width: 100%;
                        }
                    main section article {
                        border: 4px dashed black;
                        width: 25%;
                        scale : 1.2;
                        padding: 20px;
                        background-color: #f2e9e4;
                        box-shadow: 5px 5px 15px rgba(0, 0, 0, 0.3);
                        border-radius: 15px;
                        margin-top: 10rem;
                        background-color: #e5989b;}
                        article {
                            margin-bottom: 1rem auto;
                            margin-top: 2px auto;
                            }
                    </style>

                `;
                sectionTab.appendChild(article);
            }
        }
        catch (error) {
            console.log(error);
        }

    })();

}

document.getElementById("btnTab").addEventListener("click", () => {
    //recuperer valeurs des inputs
    const dateSelectionnee = document.getElementById("dateTab").value;
    const liaisonSelectionnee = document.getElementById("idLiaisonSlider").value;
    
    creerTableauBord(dateSelectionnee, liaisonSelectionnee);
});

