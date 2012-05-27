<p>Plaćanje odabanog:
<form name="placanje" action="placanjeOdabranog.php" method="post">
Ime i prezime (na način na koji piše na kartici):<br>
<input type="text" name="ime"><br>
Tip kartice:<br>
<select name="tip">
<option value="VISA">VISA</option>
<option value="MasterCard">MasterCard</option>
<option value="American Express">American Express</option>
</select><br>
Broj kartice:<br>
<input type="text" name="broj"><br>
Datum isteka:<br>
<input type="text" name="datumM" maxlength="2" size="2">/<input type="text" name="datumG" maxlength="4" size="4"><br>
CVC:
<input type="text" name="cvc" maxlength="4" size="4"><br />
<input type="submit" value="Plati">
</form>
</p>