# Koraci u podesavanju Visual Studia i SQL-a #

  * Instalirati wamp server, i mysql connector

  * Skinuti projekat preko turtoise svn. Napraviti folder za projekat i povezati ga sa projektom isto kao sto je Teo uradio, link projekta je: https://code.google.com/p/bobotrans/

  * Dodati referencu na connector u projekat (ako vec ne postoji)

  * Importovati bazu u phpmyadminu

  * U konzolu sql-a upisati:

use mysql;

GRANT ALL PRIVILEGES ON **.** to root@'%' IDENTIFIED BY 'sys';
(ovako smo root korisniku dali sve dozvole)