using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{

    public static int V = 0;
    public static int Att = 0;
    public static int End = 0;
    public static int Vit = 0;
    public static int Str = 0;
    public static int Dex = 0;
    public static int Int = 0;
    public static int Fai = 0;
    public static int Luc = 0;
    public static int Lev = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
       
    protected void Button1_Click(object sender, EventArgs e)
    {
        int Chestphys = 0;
        int Cheststrike = 0;
        int ChestSlash = 0;
        int ChestThrust = 0;
        int ChestMagic = 0;
        int ChestFire = 0;
        int ChestLightning = 0;
        int ChestDark = 0;
        int ChestBleed = 0;
        int ChestPosion;
        int ChestFrost = 0;
        int ChestCurse = 0;
        int ChestPoise = 0;
        int ChestWeight = 0;

        int Headphys = 0;
        int Headstrike = 0;
        int HeadSlash = 0;
        int HeadThrust = 0;
        int HeadMagic = 0;
        int HeadFire = 0;
        int HeadLightning = 0;
        int HeadDark = 0;
        int HeadBleed = 0;
        int HeadPosion;
        int HeadFrost = 0;
        int HeadCurse = 0;
        int HeadPoise = 0;
        int HeadWeight = 0;

        int Handsphys = 0;
        int Handsstrike = 0;
        int HandsSlash = 0;
        int HandsThrust = 0;
        int HandsMagic = 0;
        int HandsFire = 0;
        int HandsLightning = 0;
        int HandsDark = 0;
        int HandsBleed = 0;
        int HandsPosion;
        int HandsFrost = 0;
        int HandsCurse = 0;
        int HandsPoise = 0;
        int HandsWeight = 0;

        int Legsphys = 0;
        int Legsstrike = 0;
        int LegsSlash = 0;
        int LegsThrust = 0;
        int LegsMagic = 0;
        int LegsFire = 0;
        int LegsLightning = 0;
        int LegsDark = 0;
        int LegsBleed = 0;
        int LegsPosion;
        int LegsFrost = 0;
        int LegsCurse = 0;
        int LegsPoise = 0;
        int LegsWeight = 0;


        SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=Dark_Souls ;Integrated Security=true");
        try
        {
            dbConnection.Open();

            if (Chest.SelectedValue != "")
            {
                //def #  of last item minus current defense
                // command to get new armor defense(s)
                //add to spots

                SqlCommand testcommand = new SqlCommand("Select Physical from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                Chestphys = (int)testcommand.ExecuteScalar();

                SqlCommand test2command = new SqlCommand("Select Strike from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                Cheststrike = (int)test2command.ExecuteScalar();

                SqlCommand test3command = new SqlCommand("Select Slash from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestSlash = (int)test3command.ExecuteScalar();

                SqlCommand test4command = new SqlCommand("Select Thrust from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestThrust = (int)test4command.ExecuteScalar();

                SqlCommand test5command = new SqlCommand("Select Magic from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestMagic = (int)test5command.ExecuteScalar();

                SqlCommand test6command = new SqlCommand("Select Fire from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestFire = (int)test6command.ExecuteScalar();

                SqlCommand test7command = new SqlCommand("Select Lightning from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestLightning = (int)test7command.ExecuteScalar();

                SqlCommand test8command = new SqlCommand("Select Dark from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestDark = (int)test8command.ExecuteScalar();

                SqlCommand test9command = new SqlCommand("Select Bleed from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestBleed = (int)test9command.ExecuteScalar();

                SqlCommand test10command = new SqlCommand("Select Posion from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestPosion = (int)test10command.ExecuteScalar();

                SqlCommand test11command = new SqlCommand("Select Frost from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestFrost = (int)test11command.ExecuteScalar();

                SqlCommand test12command = new SqlCommand("Select Curse from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestCurse = (int)test12command.ExecuteScalar();

                SqlCommand test13command = new SqlCommand("Select Poise from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestPoise = (int)test13command.ExecuteScalar();

                SqlCommand test14command = new SqlCommand("Select Carry_Weight from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestWeight = (int)test14command.ExecuteScalar();

                //--------------------------------------------------------------Head-----------------------------------------------------------------------------------

                SqlCommand Headcommand = new SqlCommand("Select Physical from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                Headphys = (int)Headcommand.ExecuteScalar();

                SqlCommand Head2command = new SqlCommand("Select Strike from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                Headstrike = (int)Head2command.ExecuteScalar();

                SqlCommand Head3command = new SqlCommand("Select Slash from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadSlash = (int)Head3command.ExecuteScalar();

                SqlCommand Head4command = new SqlCommand("Select Thrust from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadThrust = (int)Head4command.ExecuteScalar();

                SqlCommand Head5command = new SqlCommand("Select Magic from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadMagic = (int)Head5command.ExecuteScalar();

                SqlCommand Head6command = new SqlCommand("Select Fire from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadFire = (int)Head6command.ExecuteScalar();

                SqlCommand Head7command = new SqlCommand("Select Lightning from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadLightning = (int)Head7command.ExecuteScalar();

                SqlCommand Head8command = new SqlCommand("Select Dark from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadDark = (int)Head8command.ExecuteScalar();

                SqlCommand Head9command = new SqlCommand("Select Bleed from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadBleed = (int)Head9command.ExecuteScalar();

                SqlCommand Head10command = new SqlCommand("Select Posion from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadPosion = (int)Head10command.ExecuteScalar();

                SqlCommand Head11command = new SqlCommand("Select Frost from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadFrost = (int)Head11command.ExecuteScalar();

                SqlCommand Head12command = new SqlCommand("Select Curse from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadCurse = (int)Head12command.ExecuteScalar();

                SqlCommand Head13command = new SqlCommand("Select Poise from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadPoise = (int)Head13command.ExecuteScalar();

                SqlCommand Head14command = new SqlCommand("Select Carry_Weight from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadWeight = (int)Head14command.ExecuteScalar();

                //----------------------------------------------------------------Hands---------------------------------------------------------------------------------


                SqlCommand Handscommand = new SqlCommand("Select Physical from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                Handsphys = (int)Handscommand.ExecuteScalar();

                SqlCommand Hands2command = new SqlCommand("Select Strike from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                Handsstrike = (int)Hands2command.ExecuteScalar();

                SqlCommand Hands3command = new SqlCommand("Select Slash from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsSlash = (int)Hands3command.ExecuteScalar();

                SqlCommand Hands4command = new SqlCommand("Select Thrust from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsThrust = (int)Hands4command.ExecuteScalar();

                SqlCommand Hands5command = new SqlCommand("Select Magic from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsMagic = (int)Hands5command.ExecuteScalar();

                SqlCommand Hands6command = new SqlCommand("Select Fire from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsFire = (int)Hands6command.ExecuteScalar();

                SqlCommand Hands7command = new SqlCommand("Select Lightning from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsLightning = (int)Hands7command.ExecuteScalar();

                SqlCommand Hands8command = new SqlCommand("Select Dark from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsDark = (int)Hands8command.ExecuteScalar();

                SqlCommand Hands9command = new SqlCommand("Select Bleed from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsBleed = (int)Hands9command.ExecuteScalar();

                SqlCommand Hands10command = new SqlCommand("Select Posion from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsPosion = (int)Hands10command.ExecuteScalar();

                SqlCommand Hands11command = new SqlCommand("Select Frost from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsFrost = (int)Hands11command.ExecuteScalar();

                SqlCommand Hands12command = new SqlCommand("Select Curse from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsCurse = (int)Hands12command.ExecuteScalar();

                SqlCommand Hands13command = new SqlCommand("Select Poise from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsPoise = (int)Hands13command.ExecuteScalar();

                SqlCommand Hands14command = new SqlCommand("Select Carry_Weight from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsWeight = (int)Hands14command.ExecuteScalar();

                //----------------------------------------------------------------Legs---------------------------------------------------------------------------------

                SqlCommand Legscommand = new SqlCommand("Select Physical from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                Legsphys = (int)Legscommand.ExecuteScalar();

                SqlCommand Legs2command = new SqlCommand("Select Strike from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                Legsstrike = (int)Legs2command.ExecuteScalar();

                SqlCommand Legs3command = new SqlCommand("Select Slash from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsSlash = (int)Legs3command.ExecuteScalar();

                SqlCommand Legs4command = new SqlCommand("Select Thrust from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsThrust = (int)Legs4command.ExecuteScalar();

                SqlCommand Legs5command = new SqlCommand("Select Magic from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsMagic = (int)Legs5command.ExecuteScalar();

                SqlCommand Legs6command = new SqlCommand("Select Fire from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsFire = (int)Legs6command.ExecuteScalar();

                SqlCommand Legs7command = new SqlCommand("Select Lightning from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsLightning = (int)Legs7command.ExecuteScalar();

                SqlCommand Legs8command = new SqlCommand("Select Dark from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsDark = (int)Legs8command.ExecuteScalar();

                SqlCommand Legs9command = new SqlCommand("Select Bleed from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsBleed = (int)Legs9command.ExecuteScalar();

                SqlCommand Legs10command = new SqlCommand("Select Posion from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsPosion = (int)Legs10command.ExecuteScalar();

                SqlCommand Legs11command = new SqlCommand("Select Frost from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsFrost = (int)Legs11command.ExecuteScalar();

                SqlCommand Legs12command = new SqlCommand("Select Curse from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsCurse = (int)Legs12command.ExecuteScalar();

                SqlCommand Legs13command = new SqlCommand("Select Poise from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsPoise = (int)Legs13command.ExecuteScalar();

                SqlCommand Legs14command = new SqlCommand("Select Carry_Weight from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsWeight = (int)Legs14command.ExecuteScalar();

                int TotalPhys = Chestphys + Headphys + Handsphys + Legsphys;
                int TotalStrike = ChestSlash + Headstrike + Handsstrike + Legsstrike;
                int TotalSlash = ChestSlash + HeadSlash + HandsSlash + LegsSlash;
                int TotalThrust = ChestThrust + HeadThrust + HandsThrust + LegsThrust;
                int TotalMagic = ChestMagic + HeadMagic + HandsMagic + LegsMagic;
                int TotalFire = ChestFire + HeadFire + HandsFire + LegsFire;
                int TotalLightning = ChestLightning + HeadLightning + HandsLightning + LegsLightning;
                int TotalDark = ChestDark + HeadDark + HandsDark + LegsDark;
                int TotalBleed = ChestBleed + HeadBleed + HandsBleed + LegsBleed;
                int TotalPosion = ChestPosion + HeadPosion + HandsPosion + LegsPosion;
                int TotalFrost = ChestFrost + HeadFrost + HandsFrost + LegsFrost;
                int TotalCurse = ChestCurse + HeadCurse + HandsCurse + LegsCurse;
                int TotalPoise = ChestPoise + HeadPoise + HandsPoise + LegsPoise;
                int TotalWeight = ChestWeight + HeadPoise + HandsPoise + LegsPoise;

                PhysicalDef.Text = TotalPhys.ToString();
                StrikeDef.Text = TotalStrike.ToString();
                SlashDef.Text = TotalSlash.ToString();
                ThrustDef.Text = TotalThrust.ToString();
                MagicDef.Text = TotalMagic.ToString();
                FireDef.Text = TotalFire.ToString();
                LightningDef.Text = TotalLightning.ToString();
                DarkDef.Text = TotalDark.ToString();
                BleedRes.Text = TotalBleed.ToString();
                PoisonRes.Text = TotalPosion.ToString();
                FrostRes.Text = TotalFrost.ToString();
                CurseRes.Text = TotalCurse.ToString();
                Poise.Text = TotalPoise.ToString();
                CWeight.Text = TotalWeight.ToString();

                //----------------------------------------------------------------Rings---------------------------------------------------------------------------------

                Notes.Text = "";
                SqlCommand RingE1 = new SqlCommand("Select Effects from Rings where Name = '" + Ring1.SelectedValue + "';", dbConnection);
                Notes.Text += Ring1.SelectedValue+": "+ RingE1.ExecuteScalar().ToString() + Environment.NewLine + Environment.NewLine;
                SqlCommand RingE2 = new SqlCommand("Select Effects from Rings where Name = '" + Ring2.SelectedValue + "';", dbConnection);
                Notes.Text += Ring2.SelectedValue + ": " + RingE2.ExecuteScalar().ToString() + Environment.NewLine + Environment.NewLine;
                SqlCommand RingE3 = new SqlCommand("Select Effects from Rings where Name = '" + Ring3.SelectedValue + "';", dbConnection);
                Notes.Text += Ring3.SelectedValue + ": " + RingE3.ExecuteScalar().ToString() + Environment.NewLine + Environment.NewLine;
                SqlCommand RingE4 = new SqlCommand("Select Effects from Rings where Name = '" + Ring4.SelectedValue + "';", dbConnection);
                Notes.Text += Ring4.SelectedValue + ": " + RingE4.ExecuteScalar().ToString() + Environment.NewLine + Environment.NewLine;
                //Requirements
                SqlCommand Requirements1 = new SqlCommand("Select Requirements from Weapons where Name = '" + LH1.SelectedValue + "';", dbConnection);
                Notes.Text += LH1.SelectedValue + ": " + Requirements1.ExecuteScalar().ToString() + Environment.NewLine + Environment.NewLine;
                SqlCommand Requirements2 = new SqlCommand("Select Requirements from Weapons where Name = '" + LH2.SelectedValue + "';", dbConnection);
                Notes.Text += LH2.SelectedValue + ": " + Requirements2.ExecuteScalar().ToString() + Environment.NewLine + Environment.NewLine;
                SqlCommand Requirements3 = new SqlCommand("Select Requirements from Weapons where Name = '" + LH3.SelectedValue + "';", dbConnection);
                Notes.Text += LH3.SelectedValue + ": " + Requirements3.ExecuteScalar().ToString() + Environment.NewLine + Environment.NewLine;
                SqlCommand Requirements4 = new SqlCommand("Select Requirements from Weapons where Name = '" + RH1.SelectedValue + "';", dbConnection);
                Notes.Text += RH1.SelectedValue + ": " + Requirements4.ExecuteScalar().ToString() + Environment.NewLine + Environment.NewLine;
                SqlCommand Requirements5 = new SqlCommand("Select Requirements from Weapons where Name = '" + RH2.SelectedValue + "';", dbConnection);
                Notes.Text += RH2.SelectedValue + ": " + Requirements5.ExecuteScalar().ToString() + Environment.NewLine + Environment.NewLine;
                SqlCommand Requirements6 = new SqlCommand("Select Requirements from Weapons where Name = '" + RH3.SelectedValue + "';", dbConnection);
                Notes.Text += RH3.SelectedValue + ": " + Requirements6.ExecuteScalar().ToString() + Environment.NewLine + Environment.NewLine;

                //----------------------------------------------------------------Character---------------------------------------------------------------------------------

                SqlCommand LevelConnect = new SqlCommand("Select Soul_Level from Class where Class_Name = '" + Class.SelectedValue + "';", dbConnection);
                Lev= (int)LevelConnect.ExecuteScalar();
                SqlCommand VigorConnect = new SqlCommand("Select Vigor from Class where Class_Name = '" + Class.SelectedValue + "';", dbConnection);
                V = (int)VigorConnect.ExecuteScalar();
                SqlCommand AttunementConnect = new SqlCommand("Select Attunement from Class where Class_Name = '" + Class.SelectedValue + "';", dbConnection);
                Att = (int)AttunementConnect.ExecuteScalar();
                SqlCommand EnduranceConnect = new SqlCommand("Select Endurance from Class where Class_Name = '" + Class.SelectedValue + "';", dbConnection);
                End = (int)EnduranceConnect.ExecuteScalar();
                SqlCommand VitalityConnect = new SqlCommand("Select Vitality from Class where Class_Name = '" + Class.SelectedValue + "';", dbConnection);
                Vit = (int)VitalityConnect.ExecuteScalar();
                SqlCommand StrengthConnect = new SqlCommand("Select Strength from Class where Class_Name = '" + Class.SelectedValue + "';", dbConnection);
                Str = (int)StrengthConnect.ExecuteScalar();
                SqlCommand DexterityConnect = new SqlCommand("Select Dexterity from Class where Class_Name = '" + Class.SelectedValue + "';", dbConnection);
                Dex = (int)DexterityConnect.ExecuteScalar();
                SqlCommand IntelligenceConnect = new SqlCommand("Select Intelligence from Class where Class_Name = '" + Class.SelectedValue + "';", dbConnection);
                Int = (int)IntelligenceConnect.ExecuteScalar();
                SqlCommand FaithConnect = new SqlCommand("Select Faith from Class where Class_Name = '" + Class.SelectedValue + "';", dbConnection);
                Fai = (int)FaithConnect.ExecuteScalar();
                SqlCommand LuckConnect = new SqlCommand("Select Luck from Class where Class_Name = '" + Class.SelectedValue + "';", dbConnection);
                Luc = (int)LuckConnect.ExecuteScalar();

                Vigor.Text = V.ToString();
                Attunement.Text = Att.ToString();
                Endurance.Text = End.ToString();
                Vitality.Text = Vit.ToString();
                Strength.Text = Str.ToString();
                Dexterity.Text = Dex.ToString();
                Intelligence.Text = Int.ToString();
                Faith.Text = Fai.ToString();
                Luck.Text = Luc.ToString();
                Level.Text = Lev.ToString();

            }

        }
        catch (SqlException exception)
        {

        }
        dbConnection.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Lev++;
        V++;
        Level.Text = Lev.ToString();
        Vigor.Text = V.ToString();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Lev--;
        V--;
        Level.Text = Lev.ToString();
        Vigor.Text = V.ToString();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Lev++;
        Att++;
        Level.Text = Lev.ToString();
        Attunement.Text = Att.ToString();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Lev--;
        Att--;
        Level.Text = Lev.ToString();
        Attunement.Text = Att.ToString();
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Lev++;
        End++;
        Level.Text = Lev.ToString();
        Endurance.Text = End.ToString();
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Lev--;
        End--;
        Level.Text = Lev.ToString();
        Endurance.Text = End.ToString();
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Lev++;
        Vit++;
        Level.Text = Lev.ToString();
        Vitality.Text = Vit.ToString();
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        Lev--;
        Vit--;
        Level.Text = Lev.ToString();
        Vitality.Text = Vit.ToString();
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        Lev++;
        Str++;
        Level.Text = Lev.ToString();
        Strength.Text = Str.ToString();
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        Lev--;
        Str--;
        Level.Text = Lev.ToString();
        Strength.Text = Str.ToString();
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        Lev++;
        Dex++;
        Level.Text = Lev.ToString();
        Dexterity.Text = Dex.ToString();
    }

    protected void Button13_Click(object sender, EventArgs e)
    {
        Lev--;
        Dex--;
        Level.Text = Lev.ToString();
        Dexterity.Text = Dex.ToString();
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        Lev++;
        Int++;
        Level.Text = Lev.ToString();
        Intelligence.Text = Int.ToString();
    }

    protected void Button15_Click(object sender, EventArgs e)
    {
        Lev--;
        Int--;
        Level.Text = Lev.ToString();
        Intelligence.Text = Int.ToString();
    }

    protected void Button16_Click(object sender, EventArgs e)
    {
        Lev++;
        Fai++;
        Level.Text = Lev.ToString();
        Faith.Text = Fai.ToString();
    }

    protected void Button17_Click(object sender, EventArgs e)
    {
        Lev--;
        Fai--;
        Level.Text = Lev.ToString();
        Faith.Text = Fai.ToString();
    }
    protected void Button18_Click(object sender, EventArgs e)
    {
        Lev++;
        Luc++;
        Level.Text = Lev.ToString();
        Luck.Text = Luc.ToString();
    }

    protected void Button19_Click(object sender, EventArgs e)
    {
        Lev--;
        Luc--;
        Level.Text = Lev.ToString();
        Luck.Text = Luc.ToString();
    }

}
