const lienAPI = "https://can.iutrs.unistra.fr/api/reservation/";

//fonctions de créations des cartes
const creerCartePassagerMain = (portDepart, portArrivee, dateDepart,
                    heureDepart, bateau, numRes, nomRes,
                    nomPassager, prenomPassager, catPassager,
                    prixPassager) => {

    const mainCartes = document.querySelector("main");
    const carte = document.createElement("section");
    //style de carte -> prototype fait sur une page avant
    carte.innerHTML = `
        <style>
            main {
                display: flex;
                flex-direction: column;
                align-items: center;
                justify-content: center;
            }
            
            section {
                border-radius: 25px;
                margin: 19px;
                padding: 9px;
                height: 500px;
                width: 700px;
            }

            section img {
                width: 35%;
            }

            section article {
                background-color: #e5989b;
                border: 4px dashed black;
                border-radius: 25px;
                padding: 10px;
                margin: 10px;
                box-shadow: 5px 5px 15px grey;
                width: 700px;
                height:auto;
            }
            
            article h2 {
                display: flex;
                flex-direction: column;
            }

            #container {
                display: flex;
                flex-direction: row;
                justify-content: space-between;
                align-items: center;
                width: auto;
                height: auto;
            }

            #gauche, #droite {
                max-width: 45%;
                width: 50%;
                height: 22rem;
                scale: 1.1;
                border: 1px dashed black;
                background-color: #c9ada7;
            }

            @media (max-width: 768px) {
                section {
                    width: 95%;
                    height: auto;
                    margin: 10px;
                    padding: 5px;
                }

                section article {
                    width: 95%;
                    padding: 5px;
                }

                #container {
                    flex-direction: column;
                    align-items: center;
                }

                #gauche, #droite {
                    max-width: 100%;
                    width: 90%;
                    height: auto;
                    scale: 1;
                    margin: 10px 0;
                }

                section img {
                    width: 50%;
                }
            }

            @media (max-width: 480px) {
                section {
                    width: 98%;
                    margin: 5px;
                }

                section article {
                    width: 98%;
                }

                #gauche, #droite {
                    width: 95%;
                }

                section img {
                    width: 60%;
                }

                article h2 {
                    font-size: 1.2rem;
                }

                p {
                    font-size: 0.9rem;
                }
            }
        </style>
        <article>
            <h2>Carte d'embarquement de : ${nomPassager} ${prenomPassager}</h2>

            <div id="container">
                <section id="gauche">
                    <img src="img/CAN.png">
                    <p> Gare de Départ : ${portDepart}</p>
                    <p> Gare d'Arrivée : ${portArrivee}</p>
                    <p> Date de départ : ${dateDepart}</p>
                    <p> Heure de départ : ${heureDepart}</p>
                    <p> Bateau : ${bateau}</p>
                </section>
                <section id="droite">
                    <p>Réservation : ${numRes}</p>
                    <p> Nom réservation : ${nomRes}</p>
                    <img src="img/qrcode.png">
                    <p> Nom : ${nomPassager}</p>
                    <p> Prénom : ${prenomPassager}</p>
                    <p> Catégorie : ${catPassager}</p>
                    <p> Prix : ${prixPassager} €</p>
                </section>
            </div>
        </article>`;
    mainCartes.appendChild(carte);
}

const creerCarteVehiculeMain = (portDepart, portArrivee, dateDepart,
                    heureDepart, bateau, numRes, nomRes,
                    nombre,prixVehicule,categorie, codeCategorie) => {

    const mainCartes = document.querySelector("main");
    const carte = document.createElement("section");
    //style de carte -> prototype fait sur une page avant
    carte.innerHTML = `
        <style>
            main {
                display: flex;
                flex-direction: column;
                align-items: center;
                justify-content: center;
            }
            
            section {
                border-radius: 25px;
                margin: 19px;
                padding: 9px;
                height: 500px;
                width: 700px;
            }

            section img {
                width: 35%;
            }

            section article {
                background-color: #e5989b;
                border: 4px dashed black;
                border-radius: 25px;
                padding: 10px;
                margin: 10px;
                box-shadow: 5px 5px 15px grey;
                width: 700px;
                height:auto;
            }
            
            article h2 {
                display: flex;
                flex-direction: column;
            }

            #container {
                display: flex;
                flex-direction: row;
                justify-content: space-between;
                align-items: center;
                width: auto;
                height: auto;
            }

            #gauche, #droite {
                max-width: 45%;
                width: 50%;
                height: 22rem;
                scale: 1.1;
                border: 1px dashed black;
                background-color: #c9ada7;
            }

            @media (max-width: 768px) {
                section {
                    width: 95%;
                    height: auto;
                    margin: 10px;
                    padding: 5px;
                }

                section article {
                    width: 95%;
                    padding: 5px;
                }

                #container {
                    flex-direction: column;
                    align-items: center;
                }

                #gauche, #droite {
                    max-width: 100%;
                    width: 90%;
                    height: auto;
                    scale: 1;
                    margin: 10px 0;
                }

                section img {
                    width: 50%;
                }
            }

            @media (max-width: 480px) {
                section {
                    width: 98%;
                    margin: 5px;
                }

                section article {
                    width: 98%;
                }

                #gauche, #droite {
                    width: 95%;
                }

                section img {
                    width: 60%;
                }

                article h2 {
                    font-size: 1.2rem;
                }

                p {
                    font-size: 0.9rem;
                }
            }
        </style>
        <article>
            <h2>Carte d'embarquement du véhicule : ${categorie}</h2>

            <div id="container">
                <section id="gauche">
                    <img src="img/CAN.png">
                    <p> Gare de Départ : ${portDepart}</p>
                    <p> Gare d'Arrivée : ${portArrivee}</p>
                    <p> Date de départ : ${dateDepart}</p>
                    <p> Heure de départ : ${heureDepart}</p>
                    <p> Bateau : ${bateau}</p>
                </section>
                <section id="droite">
                    <p>Réservation : ${numRes}</p>
                    <p> Nom réservation : ${nomRes}</p>
                    <img src="img/qrcode.png">
                    <p> Nombre : ${nombre}</p>
                    <p> Prix individuel: ${prixVehicule} €</p>
                    ${nombre >1 ?
                        `<p> Prix total : ${prixVehicule * nombre} €</p>`
                    : ""}
                    <p> Code catégorie : ${codeCategorie}</p>
                </section>
            </div>
        </article>`;//checker au dessus pour le prix total si nombre >1 avec le ? 
    mainCartes.appendChild(carte);
}

document.getElementById("btnSendRes").addEventListener("click", () => 
{
    const idRes = document.getElementById("resIdChoix").value;
    document.querySelector("main").innerHTML = ""; // enlever les cartes précédentes
    (async () => {
        try{
            const reponse = await fetch(`${lienAPI}${idRes}`);

            if(!reponse.ok)
            {
                throw new Error("Erreur lors de la récup des données");
            }

            const data = await reponse.json();
            //données faciles a obtenir dès le début :D
            const portD = data.portDepart;
            const portA = data.portArrivee;
            const dateD = data.date;
            const heureD = data.heure;
            const bateau = data.bateau;
            const numRes = data.id;
            const nomRes = data.nom;

            for(let i = 1; i<= data.nbPassagers;i++)
            { //parcourt des passagers
                try{

                    const repPassager = await fetch(`${lienAPI}${idRes}/passager/${i}`);

                    if(!repPassager.ok)
                    {
                        throw new Error("Erreur lors de la récup des passagers");
                    }

                    const passager = await repPassager.json();
                    console.log(passager);

                    creerCartePassagerMain(portD, portA, dateD, heureD, //creation carte
                    bateau, numRes, nomRes, passager.nom, passager.prenom,
                    passager.libelleCategorie, passager.price);
                }
                catch(error)
                {
                    console.log(error);
                }
            }
            //parcourt des vehicules    
            for(let j = 1; j<= data.nbVehicules;j++)
            {
                try{
                    const repVehicule = await fetch(`${lienAPI}${idRes}/vehicule/${j}`);

                    if(!repVehicule.ok)
                    {
                        throw new Error("Erreur lors de la récup des véhicules");
                    }

                    const vehicule = await repVehicule.json();
                    console.log(vehicule);

                    creerCarteVehiculeMain(portD, portA, dateD, heureD, //creation carte
                    bateau, numRes, nomRes, vehicule.quantite,
                    vehicule.prix, vehicule.libelle, vehicule.code);
                }
                catch(error)
                {
                    console.log(error);
                }

            }
        }

        catch(error)
        {
            console.log(error);

        }
    })(); // fonction anonyme qui s'auto-exécute
});