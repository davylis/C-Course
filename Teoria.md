## Johdanto

Tietokoneohjelmointi, tai yksinkertaisesti ohjelmointi (tai koodaus), on prosessi jolla tietokone ohjeistetaan suorittamaan määritellyt tehtävät ratkaisun saavuttamiseksi. Kyseinen prosessi koostuu useasta vaiheesta, jotka usein sisältävät seuraavat askeleet ohjelmoijalle:
- Ongelman määrittely
- Ratkaisun määrittely
- Ratkaisun muuttaminen algoritmiksi 
- Algoritmin muuttaminen ohjelmaksi
- Ohjelman suoritus ja testaus

Tie ohjelmoijan ratkaisusta toimivaksi ohjelmaksi alkaa lähdekoodista. Lähdekoodia on kokoelma koodia (ohjeet), jotka kertovat tietokoneelle mitä tehdä seuraavaksi. 

Tietokone ei kuitenkaan ymmärrä ja osaa suorittaa tätä lähdekoodia suoraan. Se täytyy tulkata tai kääntää binääriseksi konekieleksi, jonka puolestaan koneen prosessori (CPU, Central Processing Unit) suorittaa
Vaiheet:
- Korkean tason ohjelmointikieli(Java, C#, Python...)
- Assembly-kieli
- Konekieli
- Laitetaso

Ohjelmointi on melkein taidetta - jokaiseen ongelmaan on äärettömästi ratkaisuja.

Näiden ratkaisujen välillä voi olla huomattaviakin eroja, esimerkiksi tehokkuuden kannalta. 

Debuggaaminen tarkoittaa ohjelmasta virheiden ja ei-halutun käytöksen etsimistä ja poistamista.

Siihen on monia keinoja, muun muassa interaktiivinen debuggaaminen, yksikkötestaaminen, lokitiedoston analysointi ja muistivedokset (memory dump). 

Yksinkertaisin ja yleisin keino on seurata kääntäjän tai tulkin virheilmoituksia ja käyttää debuggauksen tulosteita (esim. muuttujien arvoja) ohjelman sisällä.

## .NET Framework

.NET-viitekehys on ohjelmointiviitekehys Windows-ohjelmien kokoamiseen ja ajamiseen. Se koostuu työkaluista, ohjelmointikielistä sekä kirjastoista, jotka mahdollistavat eri tyyppisten ohjelmien tekemisen. 

.NET-ohjelmat kirjoitetaan joko C#-, F#- tai Visual Basic -kielellä. Ohjelmakoodi käännetään kielelle tarkoitetulla kääntäjällä, saaden tuloksena ohjelmointikielestä riippumatonta CIL-kieltä (Common Intermediate Language), joka talletetaan .DLL- tai .EXE-tiedostoihin. 

CLR (Common Language Runtime) vastaa ohjelman suorittamisesta, tehden siitä konekieltä halutulle arkkitehtuurille, käyttäen JIT-kääntäjää (Just-In-Time Compiler), muodostaen näin viitekehyksen pohjustan.

Viitekehyksen luokkakirjasto (Framework Class Library, FCL) tarjoaa viitekehyksen perustoiminnallisuuden. FCL on kokoelma luokkia, nimiavaruuksia, rajapintoja ja arvotyyppejä .NET-ohjelmille.



