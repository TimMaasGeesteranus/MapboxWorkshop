# Workshop Mapbox


# Applicatie aanmaken
#### 1. Open visual studio en kies "create a new project"
#### 2. Kies "ASP.NET Core Web Application"
#### 3. Klik op "next"
#### 4. Noem het project MapboxWorkshop
#### 5. Klik op "create"
#### 6. Kies "Web Application (Model-View-Controller)"
#### 7. Zorg dat je ASP.NET Core 5.0 gebruikt
#### 8. Klik op create
#### 9. Klik op het groene pijltje bovenin VS. De app wordt opgestart en runt in de browser.

## Mapbox toevoegen

#### 1. Ga naar: Views>Home>Index.cshtml. Dit is de pagina waar we de map van mapbox gaan weergeven.
#### 2. Mapbox werkt met Javascript. Voeg de volgende twee lijnen code toe:
	<script src='https://api.mapbox.com/mapbox.js/v3.3.1/mapbox.js'></script>
	<link href='https://api.mapbox.com/mapbox.js/v3.3.1/mapbox.css' rel='stylesheet' />
#### 3. Voeg nu script-tags toe. Hierbinnen komt alle code van je map. 
#### 4. We beginnen met je persoonlijke token. Deze kun je op de site van Mapbox op je accountpagina vinden. Voeg deze code toe en zet op de plek van abc123 je persoonlijke token
    	L.mapbox.accessToken = 'abc123';
#### 5. Nu gaan we de map aanmaken. Dit doen we met onderstaande code:
    	var map = L.mapbox.map('map')
        	.setView([40, 0], 2)
        	.addLayer(L.mapbox.styleLayer('mapbox://styles/mapbox/streets-v11'));
#### 6. Om de map te kunnen stylen voeg je style-tags toe
#### 7. Binnen de tags zet je de volgende code:
	#map {
        	position: absolute;
        	width: 80%;
        	height: 50%;
    	}
#### 8. Nu hoeven we alleen nog maar te zorgen dat de map wordt weergegeven op de pagina. Voeg hiervoor een div toe:
	<div id='map'></div>
**!Zorg ervoor dat deze div tags boven de `script` tags van stap 3 staan!**
#### 9. Sla de wijzigingen op en run de app. Je krijg nu een wereldkaart in beeld. 

## Een marker toevoegen
#### 1. Nu is het tijd om markers toe te voegen. Dit doe je onder de plek waar je ook var map hebt aangemaakt, binnen de script tags.
    	var marker = L.divIcon({
        	className: 'marker',
        	iconSize: [60, 60]
    	});
#### 2. Je ziet dat we een className hebben toegevoegd. Hiermee kunnen de marker stylen. Voeg binnen de style tags de styling van de marker toe. We halen nu een plaatje van het internet op.
        .marker {
            background-image: url('https://www.quantmania.nl/wp-content/uploads/2018/02/map-marker-icon-300x300.png');
            background-size: cover;
            width: 50px;
            height: 50px;
            border-radius: 50%;
            cursor: pointer;
        }
#### 3. Nu is het tijd om de marker toe te voegen aan de map. Voeg binnen de script tags de volgende code toe. Doe dit onder de code van stap 1, waar je de marker aanmaakt.
    L.marker([51.988769, 5.949507], { icon: marker }).addTo(map);
#### 4. Sla de wijzigingen op en run de app. Je ziet nu een marker in beeld verschijnen. De marker staat midden op de HAN-campus.
#### 5. Het zou mooi zijn als de kaart zich meteen centreert op Arnhem. Bij het aanmaken van de map heb je de code .setView([40, 0], 2) toegevoegd. De eerste twee getallen zijn coördinaten. Verander deze naar 51.983047, 5.903408.
#### 6. De kaart centreert zich nu boven Arnhem maar is nog erg uitgezoomd. Verander dit door het derde getal van .setView te veranderen van 2 naar 12.
#### 7. Sla de wijzigingen op en run de app. Je ziet nu meteen Arnhem in beeld.

