## Listat- ja taulukot
- Luokka sisältää metodeja taulukoiden luomiseen, käsittelyyn, hakemiseen ja järjestelemiseen.
- Taulukolla on pysyvä koko. Ainoa tapa kasvattaa sen kapasiteettia on luoda uusi Array-olio ja kopioida vanhan elementit uuteen. Taulukko varaa vaaditun määrän muistia, riippumatta siitä, tullaanko muistia käyttämään tai ei
- Taulukon oletusmaksimikoko on 2 gigatavua (.NET-viitekehyksessä)

- string[] cities; // esittely
- int[] myArray = new int[5] {1, 3, 5, 7, 8}; // esittely alustuksella

- C#:n tarjoama List-kokoelmaluokka on vahvasti tyypitetty lista olioita, joita voidaan käsitellä indeksien kautta. Luokka tarjoaa myös yksinkertaisia mutta tehokkaita metodeja listalta hakemiseen sekä sen järjestelyyn ja manipuloimiseen

- Clear()
Poistaa kaikki listan elementit.
- Contains(T elementti)
Kertoo löytyykö määriteltyä elementtiä listalta.
- Exists(Predicate<T> vastaavuus)
Kertoo löytyykö listalta määriteltyä predikaatti vastaava elementti.
- Find(Predicate<T> vastaavuus)
Palauttaa ensimmäisen vastaavan esiintymän listalla.
- Insert(int indeksi, T elementti)
Lisää elementin määritellyn indeksin kohdalle.
- Reverse()
Vaihtaa listan elementit päinvastaiseen järjestykseen.
- Sort(Comparison<T> vertailu)
Järjestää listan elementit käyttäen määriteltyä vertailua Comparison<T>

- Joskus haluamme kuitenkin tallettaa ajonaikaisen datan myöhempää käyttöä varten, tai jonkun muun ohjelman käsiteltäväksi. Serialisaatioksi kutsuttu prosessi antaa meidän tallettaa olion tilan muistiosoitteeseen, tietokantaan tai tiedostoon. 
- Dataa uudelleen tarvittaessa suoritamme käänteisen prosessin, jota kutsutaan deserialisaatioksi.
- JSON-serialisaatio (nimiavaruus System.Text.Json) perustuu avoimeen standardiin JSON ja tuottaa serialisaation JSON-formaatissa.
