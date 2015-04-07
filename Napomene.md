# Spisak napomena #

  * ## Autobus i sifra voznje? ##
> > Da li treba klasa Autobus imati podatak o tome, tako nam je u dijagramu klasa, ako odlucimo da ne treba, treba dijagram izmijeniti
Amer

  * ## Voznja i dajCijenu ##
> > Kako bi klasa Voznja trebala ovo da radi? Po meni ovo samo treba u Linija. Izmijeniti dijagram Klasa...
Amer
  * ## Stanica i id ##
> > Treba promijeniti u dijagramu klasa atribut "id" u "sifraStanice", da bude dosljedno imenovanje.
Amer

  * ## Linija i dodajVoznju ##
> > Na dijagramu klasa potrebno dodati parametar autobus:Autobus u dodajVoznju
Amer

  * ## Lista voznji u klasi Linija ##

> Da li da ona bude nesto tipa Priority queue-a, sortiran po vremenu polaska (tako bismo najlakse brisali stare voznje)?
Amer
  * ## Kupac ##
> > Promijeniti u klasi Kupac atribut "sifra" u "sifraKupca", zbog dosljednog imenovanja.
Amer
  * ## KupacSaPopustom ##

> Ne vidim potrebu da imamo klasu i za studenta i za penzionera, pa sam sve to stopio u klasu KupacSaPopustom, gdje cu dodati jos atribut tipKupca, podaci. Konstante vezane za iznos popusta ce se nalaziti u poseboj klasi sa konstantama.

  * ## Izvjestaj ##
> > updateovati atribude i metode izjvestaja
Amer

  * ## Poruka ##

> dodati sifraPoruke
Amer

  * ## SistemskiEntiteti ##
> Da li idu na dijagram klasa?
Amer

  * ## SuceljeRedaVoznje ##
> vratiPolazneVoznjeStanice i vratiDolazneVoznjeStanice vracaju kao tip novu klasu VoznjaUStanici
vratiSlobodnaMjestaUAutobusu je preslo u vratiZauzetaMjestaUAutobusu
izbaceno vratiModelAutobusa i vratiVoznjePoLiniji - to se direktno dobije iz odgovarajucih klasa
izbacena metoda vratiCijenu (ona je implementirana u Linija)