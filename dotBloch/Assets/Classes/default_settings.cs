class default_settings
{
    public static PrintBlochSettings printing_blochspere(){
        PrintBlochSettings printing_blochspere_settings;
        printing_blochspere_settings = new PrintBlochSettings(true,false,3,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.i);
        return printing_blochspere_settings;
    }
}

