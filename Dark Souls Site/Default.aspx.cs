using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
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
                //PhysicalDef.Text = testcommand.ExecuteScalar().ToString();

                SqlCommand test2command = new SqlCommand("Select Strike from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                Cheststrike = (int)test2command.ExecuteScalar();
                //StrikeDef.Text = test2command.ExecuteScalar().ToString();

                SqlCommand test3command = new SqlCommand("Select Slash from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestSlash = (int)test3command.ExecuteScalar();
                //SlashDef.Text = test3command.ExecuteScalar().ToString();

                SqlCommand test4command = new SqlCommand("Select Thrust from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestThrust = (int)test4command.ExecuteScalar();
                //ThrustDef.Text = test4command.ExecuteScalar().ToString();

                SqlCommand test5command = new SqlCommand("Select Magic from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestMagic = (int)test5command.ExecuteScalar();
                //MagicDef.Text = test5command.ExecuteScalar().ToString();

                SqlCommand test6command = new SqlCommand("Select Fire from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestFire = (int)test6command.ExecuteScalar();
                //FireDef.Text = test6command.ExecuteScalar().ToString();

                SqlCommand test7command = new SqlCommand("Select Lightning from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestLightning = (int)test7command.ExecuteScalar();
                //LightningDef.Text = test7command.ExecuteScalar().ToString();

                SqlCommand test8command = new SqlCommand("Select Dark from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestDark = (int)test8command.ExecuteScalar();
                //DarkDef.Text = test8command.ExecuteScalar().ToString();

                SqlCommand test9command = new SqlCommand("Select Bleed from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestBleed = (int)test9command.ExecuteScalar();
                //BleedRes.Text = test9command.ExecuteScalar().ToString();

                SqlCommand test10command = new SqlCommand("Select Posion from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestPosion = (int)test10command.ExecuteScalar();
                //PoisonRes.Text = test10command.ExecuteScalar().ToString();

                SqlCommand test11command = new SqlCommand("Select Frost from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestFrost = (int)test11command.ExecuteScalar();
                //FrostRes.Text = test11command.ExecuteScalar().ToString();

                SqlCommand test12command = new SqlCommand("Select Curse from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestCurse = (int)test12command.ExecuteScalar();
                //CurseRes.Text = test12command.ExecuteScalar().ToString();

                SqlCommand test13command = new SqlCommand("Select Poise from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestPoise = (int)test13command.ExecuteScalar();
                //.Text = testcommand.ExecuteScalar().ToString();

                SqlCommand test14command = new SqlCommand("Select Carry_Weight from Chest where Name = '" + Chest.SelectedValue + "';", dbConnection);
                ChestWeight = (int)test14command.ExecuteScalar();
                //.Text = testcommand.ExecuteScalar().ToString();

                //--------------------------------------------------------------Head-----------------------------------------------------------------------------------

                SqlCommand Headcommand = new SqlCommand("Select Physical from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                Headphys = (int)Headcommand.ExecuteScalar();
                //PhysicalDef.Text = testcommand.ExecuteScalar().ToString();

                SqlCommand Head2command = new SqlCommand("Select Strike from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                Headstrike = (int)Head2command.ExecuteScalar();
                //StrikeDef.Text = test2command.ExecuteScalar().ToString();

                SqlCommand Head3command = new SqlCommand("Select Slash from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadSlash = (int)Head3command.ExecuteScalar();
                //SlashDef.Text = test3command.ExecuteScalar().ToString();

                SqlCommand Head4command = new SqlCommand("Select Thrust from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadThrust = (int)Head4command.ExecuteScalar();
                //ThrustDef.Text = test4command.ExecuteScalar().ToString();

                SqlCommand Head5command = new SqlCommand("Select Magic from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadMagic = (int)Head5command.ExecuteScalar();
                //MagicDef.Text = test5command.ExecuteScalar().ToString();

                SqlCommand Head6command = new SqlCommand("Select Fire from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadFire = (int)Head6command.ExecuteScalar();
                //FireDef.Text = test6command.ExecuteScalar().ToString();

                SqlCommand Head7command = new SqlCommand("Select Lightning from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadLightning = (int)Head7command.ExecuteScalar();
                //LightningDef.Text = test7command.ExecuteScalar().ToString();

                SqlCommand Head8command = new SqlCommand("Select Dark from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadDark = (int)Head8command.ExecuteScalar();
                //DarkDef.Text = test8command.ExecuteScalar().ToString();

                SqlCommand Head9command = new SqlCommand("Select Bleed from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadBleed = (int)Head9command.ExecuteScalar();
                //BleedRes.Text = test9command.ExecuteScalar().ToString();

                SqlCommand Head10command = new SqlCommand("Select Posion from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadPosion = (int)Head10command.ExecuteScalar();
                //PoisonRes.Text = test10command.ExecuteScalar().ToString();

                SqlCommand Head11command = new SqlCommand("Select Frost from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadFrost = (int)Head11command.ExecuteScalar();
                //FrostRes.Text = test11command.ExecuteScalar().ToString();

                SqlCommand Head12command = new SqlCommand("Select Curse from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadCurse = (int)Head12command.ExecuteScalar();
                //CurseRes.Text = test12command.ExecuteScalar().ToString();

                SqlCommand Head13command = new SqlCommand("Select Poise from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadPoise = (int)Head13command.ExecuteScalar();
                //.Text = testcommand.ExecuteScalar().ToString();

                SqlCommand Head14command = new SqlCommand("Select Carry_Weight from Head where Name = '" + Head.SelectedValue + "';", dbConnection);
                HeadWeight = (int)Head14command.ExecuteScalar();
                //.Text = testcommand.ExecuteScalar().ToString();

                //----------------------------------------------------------------Hands---------------------------------------------------------------------------------


                SqlCommand Handscommand = new SqlCommand("Select Physical from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                Handsphys = (int)Handscommand.ExecuteScalar();
                //PhysicalDef.Text = testcommand.ExecuteScalar().ToString();

                SqlCommand Hands2command = new SqlCommand("Select Strike from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                Handsstrike = (int)Hands2command.ExecuteScalar();
                //StrikeDef.Text = test2command.ExecuteScalar().ToString();

                SqlCommand Hands3command = new SqlCommand("Select Slash from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsSlash = (int)Hands3command.ExecuteScalar();
                //SlashDef.Text = test3command.ExecuteScalar().ToString();

                SqlCommand Hands4command = new SqlCommand("Select Thrust from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsThrust = (int)Hands4command.ExecuteScalar();
                //ThrustDef.Text = test4command.ExecuteScalar().ToString();

                SqlCommand Hands5command = new SqlCommand("Select Magic from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsMagic = (int)Hands5command.ExecuteScalar();
                //MagicDef.Text = test5command.ExecuteScalar().ToString();

                SqlCommand Hands6command = new SqlCommand("Select Fire from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsFire = (int)Hands6command.ExecuteScalar();
                //FireDef.Text = test6command.ExecuteScalar().ToString();

                SqlCommand Hands7command = new SqlCommand("Select Lightning from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsLightning = (int)Hands7command.ExecuteScalar();
                //LightningDef.Text = test7command.ExecuteScalar().ToString();

                SqlCommand Hands8command = new SqlCommand("Select Dark from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsDark = (int)Hands8command.ExecuteScalar();
                //DarkDef.Text = test8command.ExecuteScalar().ToString();

                SqlCommand Hands9command = new SqlCommand("Select Bleed from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsBleed = (int)Hands9command.ExecuteScalar();
                //BleedRes.Text = test9command.ExecuteScalar().ToString();

                SqlCommand Hands10command = new SqlCommand("Select Posion from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsPosion = (int)Hands10command.ExecuteScalar();
                //PoisonRes.Text = test10command.ExecuteScalar().ToString();

                SqlCommand Hands11command = new SqlCommand("Select Frost from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsFrost = (int)Hands11command.ExecuteScalar();
                //FrostRes.Text = test11command.ExecuteScalar().ToString();

                SqlCommand Hands12command = new SqlCommand("Select Curse from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsCurse = (int)Hands12command.ExecuteScalar();
                //CurseRes.Text = test12command.ExecuteScalar().ToString();

                SqlCommand Hands13command = new SqlCommand("Select Poise from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsPoise = (int)Hands13command.ExecuteScalar();
                //.Text = testcommand.ExecuteScalar().ToString();

                SqlCommand Hands14command = new SqlCommand("Select Carry_Weight from Hands where Name = '" + Hands.SelectedValue + "';", dbConnection);
                HandsWeight = (int)Hands14command.ExecuteScalar();
                //.Text = testcommand.ExecuteScalar().ToString();

                //----------------------------------------------------------------Legs---------------------------------------------------------------------------------

                SqlCommand Legscommand = new SqlCommand("Select Physical from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                Legsphys = (int)Legscommand.ExecuteScalar();
                //PhysicalDef.Text = testcommand.ExecuteScalar().ToString();

                SqlCommand Legs2command = new SqlCommand("Select Strike from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                Legsstrike = (int)Legs2command.ExecuteScalar();
                //StrikeDef.Text = test2command.ExecuteScalar().ToString();

                SqlCommand Legs3command = new SqlCommand("Select Slash from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsSlash = (int)Legs3command.ExecuteScalar();
                //SlashDef.Text = test3command.ExecuteScalar().ToString();

                SqlCommand Legs4command = new SqlCommand("Select Thrust from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsThrust = (int)Legs4command.ExecuteScalar();
                //ThrustDef.Text = test4command.ExecuteScalar().ToString();

                SqlCommand Legs5command = new SqlCommand("Select Magic from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsMagic = (int)Legs5command.ExecuteScalar();
                //MagicDef.Text = test5command.ExecuteScalar().ToString();

                SqlCommand Legs6command = new SqlCommand("Select Fire from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsFire = (int)Legs6command.ExecuteScalar();
                //FireDef.Text = test6command.ExecuteScalar().ToString();

                SqlCommand Legs7command = new SqlCommand("Select Lightning from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsLightning = (int)Legs7command.ExecuteScalar();
                //LightningDef.Text = test7command.ExecuteScalar().ToString();

                SqlCommand Legs8command = new SqlCommand("Select Dark from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsDark = (int)Legs8command.ExecuteScalar();
                //DarkDef.Text = test8command.ExecuteScalar().ToString();

                SqlCommand Legs9command = new SqlCommand("Select Bleed from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsBleed = (int)Legs9command.ExecuteScalar();
                //BleedRes.Text = test9command.ExecuteScalar().ToString();

                SqlCommand Legs10command = new SqlCommand("Select Posion from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsPosion = (int)Legs10command.ExecuteScalar();
                //PoisonRes.Text = test10command.ExecuteScalar().ToString();

                SqlCommand Legs11command = new SqlCommand("Select Frost from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsFrost = (int)Legs11command.ExecuteScalar();
                //FrostRes.Text = test11command.ExecuteScalar().ToString();

                SqlCommand Legs12command = new SqlCommand("Select Curse from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsCurse = (int)Legs12command.ExecuteScalar();
                //CurseRes.Text = test12command.ExecuteScalar().ToString();

                SqlCommand Legs13command = new SqlCommand("Select Poise from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsPoise = (int)Legs13command.ExecuteScalar();
                //.Text = testcommand.ExecuteScalar().ToString();

                SqlCommand Legs14command = new SqlCommand("Select Carry_Weight from Legs where Name = '" + Legs.SelectedValue + "';", dbConnection);
                LegsWeight = (int)Legs14command.ExecuteScalar();
                //.Text = testcommand.ExecuteScalar().ToString();

                int TotalPhys = Chestphys + Headphys + Handsphys + Legsphys;
                PhysicalDef.Text = TotalPhys.ToString();
            }

        }
        catch (SqlException exception)
        {

        }
        dbConnection.Close();
    }
}
