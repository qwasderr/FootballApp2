using System.Text.Json;
using System.Text.Json.Serialization;
namespace FootballApp2.Models.JsonModels.RootJsonModelTeam
{
    public class Rootobject3
    {
        public Props props { get; set; }
        public string page { get; set; }
        public Query query { get; set; }
        public string buildId { get; set; }
        public bool isFallback { get; set; }
        public int[] dynamicIds { get; set; }
        public bool customServer { get; set; }
        public bool gip { get; set; }
        public bool appGip { get; set; }
        public object[] scriptLoader { get; set; }
    }

    public class Props
    {
        public Pageprops pageProps { get; set; }
        public string locale { get; set; }
        public Messages messages { get; set; }
        public Routes routes { get; set; }
        public Paths paths { get; set; }
        public Footerevent[] footerEvents { get; set; }
        public Sporttranslations sportTranslations { get; set; }
        public Translatedroute translatedRoute { get; set; }
        public bool isEmbed { get; set; }
        public bool isPickem { get; set; }
        public bool isFullPage { get; set; }
        public string requestUrl { get; set; }
        public Initialstate initialState { get; set; }
    }

    public class Pageprops
    {
        public Uniquetournament uniqueTournament { get; set; }
        public Season[] seasons { get; set; }
        public Seo seo { get; set; }
        public Info info { get; set; }
        public Params _params { get; set; }
    }

    public class Uniquetournament
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string primaryColorHex { get; set; }
        public string secondaryColorHex { get; set; }
        public Logo logo { get; set; }
        public Darklogo darkLogo { get; set; }
        public Category category { get; set; }
        public int userCount { get; set; }
        public int tier { get; set; }
        public Titleholder titleHolder { get; set; }
        public int titleHolderTitles { get; set; }
        public int mostTitles { get; set; }
        public Mosttitlesteam[] mostTitlesTeams { get; set; }
        public object[] linkedUniqueTournaments { get; set; }
        public bool hasStandingsGroups { get; set; }
        public bool hasRounds { get; set; }
        public bool hasPlayoffSeries { get; set; }
        public object[] upperDivisions { get; set; }
        public Lowerdivision[] lowerDivisions { get; set; }
        public bool crowdsourcingEnabled { get; set; }
        public bool hasPerformanceGraphFeature { get; set; }
        public Periodlength periodLength { get; set; }
        public int id { get; set; }
        public Country1 country { get; set; }
        public int startDateTimestamp { get; set; }
        public int endDateTimestamp { get; set; }
        public bool displayInverseHomeAwayTeams { get; set; }
    }

    public class Logo
    {
        public string md5 { get; set; }
        public int id { get; set; }
    }

    public class Darklogo
    {
        public string md5 { get; set; }
        public int id { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public string slug { get; set; }
        public Sport sport { get; set; }
        public int id { get; set; }
        public string flag { get; set; }
        public string alpha2 { get; set; }
    }

    public class Sport
    {
        public string name { get; set; }
        public string slug { get; set; }
        public int id { get; set; }
    }

    public class Titleholder
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string shortName { get; set; }
        public string gender { get; set; }
        public Sport1 sport { get; set; }
        public int userCount { get; set; }
        public string nameCode { get; set; }
        public bool disabled { get; set; }
        public bool national { get; set; }
        public int type { get; set; }
        public int id { get; set; }
        public Country country { get; set; }
        public Teamcolors teamColors { get; set; }
    }

    public class Sport1
    {
        public string name { get; set; }
        public string slug { get; set; }
        public int id { get; set; }
    }

    public class Country
    {
        public string alpha2 { get; set; }
        public string name { get; set; }
    }

    public class Teamcolors
    {
        public string primary { get; set; }
        public string secondary { get; set; }
        public string text { get; set; }
    }

    public class Periodlength
    {
    }

    public class Country1
    {
    }

    public class Mosttitlesteam
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string shortName { get; set; }
        public string gender { get; set; }
        public Sport2 sport { get; set; }
        public int userCount { get; set; }
        public string nameCode { get; set; }
        public bool disabled { get; set; }
        public bool national { get; set; }
        public int type { get; set; }
        public int id { get; set; }
        public Country2 country { get; set; }
        public Teamcolors1 teamColors { get; set; }
    }

    public class Sport2
    {
        public string name { get; set; }
        public string slug { get; set; }
        public int id { get; set; }
    }

    public class Country2
    {
        public string alpha2 { get; set; }
        public string name { get; set; }
    }

    public class Teamcolors1
    {
        public string primary { get; set; }
        public string secondary { get; set; }
        public string text { get; set; }
    }

    public class Lowerdivision
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string primaryColorHex { get; set; }
        public string secondaryColorHex { get; set; }
        public Logo1 logo { get; set; }
        public Category1 category { get; set; }
        public int tier { get; set; }
        public bool hasRounds { get; set; }
        public bool hasPlayoffSeries { get; set; }
        public bool crowdsourcingEnabled { get; set; }
        public bool hasPerformanceGraphFeature { get; set; }
        public Periodlength1 periodLength { get; set; }
        public int id { get; set; }
        public Country3 country { get; set; }
        public int startDateTimestamp { get; set; }
        public int endDateTimestamp { get; set; }
        public bool displayInverseHomeAwayTeams { get; set; }
    }

    public class Logo1
    {
        public string md5 { get; set; }
        public int id { get; set; }
    }

    public class Category1
    {
        public string name { get; set; }
        public string slug { get; set; }
        public Sport3 sport { get; set; }
        public int id { get; set; }
        public string flag { get; set; }
        public string alpha2 { get; set; }
    }

    public class Sport3
    {
        public string name { get; set; }
        public string slug { get; set; }
        public int id { get; set; }
    }

    public class Periodlength1
    {
    }

    public class Country3
    {
    }

    public class Seo
    {
        public string[] otherNames { get; set; }
        public string grade { get; set; }
        public string firstSeasonWinnerName { get; set; }
        public Largeststadium largestStadium { get; set; }
        public Lastseasonattendance lastSeasonAttendance { get; set; }
        public Tvpartner[] tvPartners { get; set; }
        public Officialorganisation officialOrganisation { get; set; }
        public Lastseasontopscorer[] lastSeasonTopScorers { get; set; }
        public int teamsCount { get; set; }
        public int tablesCount { get; set; }
        public int relegatingTeamsCount { get; set; }
        public Promotion[] promotions { get; set; }
        public int gamesCount { get; set; }
        public int frequency { get; set; }
        public string[] mostPopularTeams { get; set; }
        public Preliminaryround preliminaryRound { get; set; }
        public Maincompetition mainCompetition { get; set; }
        public int roundsCount { get; set; }
        public string[] promotedTeams { get; set; }
        public Uniquetournament1 uniqueTournament { get; set; }
        public string competitionType { get; set; }
        public string gender { get; set; }
        public string firstSeasonYear { get; set; }
        public bool hasPlayoff { get; set; }
        public string[] mostTitlesNames { get; set; }
    }

    public class Largeststadium
    {
        public string teamName { get; set; }
        public int capacity { get; set; }
    }

    public class Lastseasonattendance
    {
        public int highest { get; set; }
        public string highestHomeTeam { get; set; }
        public string highestAwayTeam { get; set; }
        public int total { get; set; }
        public int average { get; set; }
    }

    public class Officialorganisation
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Preliminaryround
    {
    }

    public class Maincompetition
    {
    }

    public class Uniquetournament1
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string primaryColorHex { get; set; }
        public string secondaryColorHex { get; set; }
        public Category2 category { get; set; }
        public int userCount { get; set; }
        public int id { get; set; }
        public bool displayInverseHomeAwayTeams { get; set; }
    }

    public class Category2
    {
        public string name { get; set; }
        public string slug { get; set; }
        public Sport4 sport { get; set; }
        public int id { get; set; }
        public string flag { get; set; }
        public string alpha2 { get; set; }
    }

    public class Sport4
    {
        public string name { get; set; }
        public string slug { get; set; }
        public int id { get; set; }
    }

    public class Tvpartner
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Lastseasontopscorer
    {
        public string name { get; set; }
        public int goals { get; set; }
    }

    public class Promotion
    {
        public string competitionName { get; set; }
        public int promotionCount { get; set; }
    }

    public class Info
    {
        public int goals { get; set; }
        public int homeTeamWins { get; set; }
        public int awayTeamWins { get; set; }
        public int draws { get; set; }
        public int yellowCards { get; set; }
        public int redCards { get; set; }
        public object[] newcomersUpperDivision { get; set; }
        public Newcomerslowerdivision[] newcomersLowerDivision { get; set; }
        public object[] newcomersOther { get; set; }
        public int numberOfCompetitors { get; set; }
        public int id { get; set; }
        public string[] hostCountries { get; set; }
    }

    public class Newcomerslowerdivision
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string shortName { get; set; }
        public string gender { get; set; }
        public Sport5 sport { get; set; }
        public int userCount { get; set; }
        public string nameCode { get; set; }
        public bool disabled { get; set; }
        public bool national { get; set; }
        public int type { get; set; }
        public int id { get; set; }
        public Teamcolors2 teamColors { get; set; }
    }

    public class Sport5
    {
        public string name { get; set; }
        public string slug { get; set; }
        public int id { get; set; }
    }

    public class Teamcolors2
    {
        public string primary { get; set; }
        public string secondary { get; set; }
        public string text { get; set; }
    }

    public class Params
    {
        public string sport { get; set; }
        public string category { get; set; }
        public string tournament { get; set; }
        public string id { get; set; }
    }

    public class Season
    {
        public string name { get; set; }
        public string year { get; set; }
        public bool editor { get; set; }
        public int id { get; set; }
        public Seasoncoverageinfo seasonCoverageInfo { get; set; }
    }

    public class Seasoncoverageinfo
    {
    }

    public class Messages
    {
        public string detailstype { get; set; }
        public string detailstournamentInfo { get; set; }
        public string detailsmatchInfo { get; set; }
        public string detailsfightInfo { get; set; }
        public string detailslocation { get; set; }
        public string detailsvenue { get; set; }
        public string detailscountry { get; set; }
        public string detailsreferee { get; set; }
        public string detailsavgCards { get; set; }
        public string detailsattendance { get; set; }
        public string detailstossWin { get; set; }
        public string detailstossDecision { get; set; }
        public string detailsumpireN { get; set; }
        public string detailstvUmpire { get; set; }
        public string detailsmanOfMatch { get; set; }
        public string detailspossibleLineups { get; set; }
        public string detailsaverageRating { get; set; }
        public string detailswinningOdds { get; set; }
        public string detailswinningOddstext { get; set; }
        public string details { get; set; }
        public string detailsstatistics { get; set; }
        public string detailsextras { get; set; }
        public string detailstotal { get; set; }
        public string detailsscore { get; set; }
        public string detailsover { get; set; }
        public string detailsballs { get; set; }
        public string detailspartnership { get; set; }
        public string detailshome { get; set; }
        public string detailsaway { get; set; }
        public string detailsh2h { get; set; }
        public string detailsplayedAt { get; set; }
        public string detailsthisTournament { get; set; }
        public string detailsvoteYouMark { get; set; }
        public string detailswhoWillWin { get; set; }
        public string detailsscored { get; set; }
        public string detailsconceded { get; set; }
        public string detailshead2head { get; set; }
        public string detailsheadToHead { get; set; }
        public string detailsmanagerHead2head { get; set; }
        public string detailshomeAway { get; set; }
        public string detailsgoalDistribution { get; set; }
        public string time_left { get; set; }
        public string droppingOddsmatchOdds { get; set; }
        public string droppingOddschanceOfWinning { get; set; }
        public string droppingOddsbasedOnOdds { get; set; }
        public string droppingOddsbasedOnHistory { get; set; }
        public string droppingOddshighValueStreaks { get; set; }
        public string droppingOddsteamStreaks { get; set; }
        public string droppingOddsh2hStreaks { get; set; }
        public string droppingOddstop20TeamStreaks { get; set; }
        public string droppingOddsallSports { get; set; }
        public string droppingOddsnextMatch48Hours { get; set; }
        public string droppingOddstop20H2H { get; set; }
        public string droppingOddswins { get; set; }
        public string droppingOddsoddsForTeam { get; set; }
        public string droppingOddschanceBasedOnOdds { get; set; }
        public string droppingOddschanceBasedOnHistory { get; set; }
        public string profilejoinDate { get; set; }
        public string profiletvContributions { get; set; }
        public string comments { get; set; }
        public string profiletotalComments { get; set; }
        public string profilelikesReceived { get; set; }
        public string profilepredictions { get; set; }
        public string profilepredictionsCurrent { get; set; }
        public string profilelast30Days { get; set; }
        public string profilepredictionsallTime { get; set; }
        public string profilecorrectPredictions { get; set; }
        public string profilecorrectOdds { get; set; }
        public string profilevotedPredictions { get; set; }
        public string profileroi { get; set; }
        public string profilepredictorsRank { get; set; }
        public string nickname { get; set; }
        public string nicknameothersSeeYou { get; set; }
        public string edit { get; set; }
        public string profilefollowEditor { get; set; }
        public string profileeventsVoted { get; set; }
        public string topPredictors { get; set; }
        public string profile_sync_info { get; set; }
        public string profilesyncAcross { get; set; }
        public string profilepredictionsEmpty { get; set; }
        public string profilesignedWith { get; set; }
        public string profileaccept { get; set; }
        public string profilehideRecent { get; set; }
        public string profileshowRecent { get; set; }
        public string profiletopPredictorsInfo { get; set; }
        public string info { get; set; }
        public string stadium { get; set; }
        public string teamInfotitle { get; set; }
        public string capacity { get; set; }
        public string city { get; set; }
        public string teamInfototalPlayers { get; set; }
        public string teamInfoforeignPlayers { get; set; }
        public string teamInfoaverageAge { get; set; }
        public string teamInfonationalTeamPlayers { get; set; }
        public string transfersarrivals { get; set; }
        public string transfersdepartures { get; set; }
        public string transfersnorecent { get; set; }
        public string transferslatest { get; set; }
        public string transferslatestArrivals { get; set; }
        public string transferslatestDepartures { get; set; }
        public string tvChannels { get; set; }
        public string bestRatedPlayers { get; set; }
        public string bestBasketballPlayers { get; set; }
        public string polePositions { get; set; }
        public string podiums { get; set; }
        public string gridPosition { get; set; }
        public string pitStops { get; set; }
        public string laps { get; set; }
        public string bestLap { get; set; }
        public string lapsLed { get; set; }
        public string status { get; set; }
        public string schedule { get; set; }
        public string circuit { get; set; }
        public string circuitLength { get; set; }
        public string raceDistance { get; set; }
        public string lapRecord { get; set; }
        public string allPositions { get; set; }
        public string playerPositions { get; set; }
        public string inProgress { get; set; }
        public string livePosition { get; set; }
        public string calendarpinnedLeaguesInfo { get; set; }
        public string eventListnoAvailableEvents { get; set; }
        public string eventListshowListOdds { get; set; }
        public string eventListpinnedLeagues { get; set; }
        public string eventListnoPinnedLeagues { get; set; }
        public string eventListaddedPinnedLeagues { get; set; }
        public string eventListremovedPinnedLeagues { get; set; }
        public string eventListnoEventsToday { get; set; }
        public string eventListnoLiveEvents { get; set; }
        public string eventListcheckLater { get; set; }
        public string eventListshowAllMatches { get; set; }
        public string eventListmeanwhileCheck { get; set; }
        public string eventListtryDifferentDate { get; set; }
        public string eventListfeaturedOdds { get; set; }
        public string eventListfeaturedMatch { get; set; }
        public string eventListcategoryallTournaments { get; set; }
        public string eventListcategoryrecentTournaments { get; set; }
        public string singles { get; set; }
        public string esportsfro { get; set; }
        public string esportsafterStatistics { get; set; }
        public string teamseasonRanked { get; set; }
        public string teamreceiveNotifications { get; set; }
        public string teamfoundationDate { get; set; }
        public string teamestablished { get; set; }
        public string teamchampionshipTitles { get; set; }
        public string teamseasonStats { get; set; }
        public string teamplayerInfo { get; set; }
        public string teamcurrentRank { get; set; }
        public string teamcareerHigh { get; set; }
        public string appaddToHomeScreenPrompt { get; set; }
        public string appsearch { get; set; }
        public string app_favourites { get; set; }
        public string apppredictionTips { get; set; }
        public string appsportPredictionTips { get; set; }
        public string appdroppingOdds { get; set; }
        public string appsportDroppingOdds { get; set; }
        public string appwinningOdds { get; set; }
        public string appsportWinningOdds { get; set; }
        public string appprofile { get; set; }
        public string appstandings { get; set; }
        public string download { get; set; }
        public string suggested { get; set; }
        public string recent { get; set; }
        public string teamPlayerslistView { get; set; }
        public string teamPlayersboxView { get; set; }
        public string bottomNavmatches { get; set; }
        public string bottomNavleagues { get; set; }
        public string bottomNavfollowing { get; set; }
        public string bottomNavmenu { get; set; }
        public string basicresults { get; set; }
        public string basicfixtures { get; set; }
        public string basicviewProfile { get; set; }
        public string basicshare { get; set; }
        public string basiccategories { get; set; }
        public string basicadvertisement { get; set; }
        public string basicodds { get; set; }
        public string readMore { get; set; }
        public string basicareU18 { get; set; }
        public string betting_odds_play_responsibly { get; set; }
        public string age_verification_title { get; set; }
        public string age_verification_text { get; set; }
        public string age_verification_over_25 { get; set; }
        public string age_verification_18_to_24 { get; set; }
        public string age_verification_under_18 { get; set; }
        public string odds_and_ads_settings_title { get; set; }
        public string odds_and_ads_show { get; set; }
        public string odds_and_ads_hide_all { get; set; }
        public string odds_and_ads_opt_out { get; set; }
        public string basicteam { get; set; }
        public string basicconfirm { get; set; }
        public string basicprofile { get; set; }
        public string basicfullName { get; set; }
        public string basicpublished { get; set; }
        public string oddsprovider { get; set; }
        public string oddsbettingOdds { get; set; }
        public string oddsnoBettingOdds { get; set; }
        public string oddsadditionalOdds { get; set; }
        public string oddsgambleResponsibly { get; set; }
        public string oddsctanotstarted { get; set; }
        public string oddsctanotstartedage { get; set; }
        public string oddslive { get; set; }
        public string oddsfeaturedBy { get; set; }
        public string basicdismiss { get; set; }
        public string basicfollow { get; set; }
        public string basicfollowing { get; set; }
        public string basicok { get; set; }
        public string basicremoved { get; set; }
        public string basicundo { get; set; }
        public string basicfollowersWithCount { get; set; }
        public string basicselectAll { get; set; }
        public string basicdeselectAll { get; set; }
        public string basicsave { get; set; }
        public string basictoday { get; set; }
        public string basictomorrow { get; set; }
        public string basicseen { get; set; }
        public string basicawaitingConfirmation { get; set; }
        public string basiclive { get; set; }
        public string basiccancel { get; set; }
        public string basicnEvents { get; set; }
        public string basicnoEvents { get; set; }
        public string basicprevious { get; set; }
        public string basicnext { get; set; }
        public string basicclose { get; set; }
        public string basiccountries { get; set; }
        public string basicclubs { get; set; }
        public string basicrecentForm { get; set; }
        public string basicall { get; set; }
        public string basicleft { get; set; }
        public string basicright { get; set; }
        public string basicapply { get; set; }
        public string basicloading { get; set; }
        public string basicnotifications { get; set; }
        public string basicname { get; set; }
        public string basicheight { get; set; }
        public string basicrank { get; set; }
        public string basicvoted { get; set; }
        public string basiccorrect { get; set; }
        public string basicresidence { get; set; }
        public string basicbirthplace { get; set; }
        public string basicallow { get; set; }
        public string basichere { get; set; }
        public string basiccopiedToClipboard { get; set; }
        public string basicdownloadSofascore { get; set; }
        public string basicdownloadNow { get; set; }
        public string basicliveScoreApp { get; set; }
        public string basictheme { get; set; }
        public string basicautoTheme { get; set; }
        public string basiclightTheme { get; set; }
        public string basicdarkTheme { get; set; }
        public string basicnightTheme { get; set; }
        public string basicamoledTheme { get; set; }
        public string basiccontractUntil { get; set; }
        public string NA { get; set; }
        public string max { get; set; }
        public string yettoperform { get; set; }
        public string sorry { get; set; }
        public string notavailableincountry { get; set; }
        public string backtoapp { get; set; }
        public string bettingdrop { get; set; }
        public string bettingemptyStreaks { get; set; }
        public string bettingemptyHighValueStreaks { get; set; }
        public string objectives { get; set; }
        public string banPhase { get; set; }
        public string whatIsThis { get; set; }
        public string expectedGoalsAbout { get; set; }
        public string goals_prevented_info_text { get; set; }
        public string basictopLeagues { get; set; }
        public string basicrankings { get; set; }
        public string basicallLeagues { get; set; }
        public string basicfilter { get; set; }
        public string rankingscategory { get; set; }
        public string rankingscheckBackLater { get; set; }
        public string rankingswillAppear { get; set; }
        public string basiclastUpdated { get; set; }
        public string basicofficial { get; set; }
        public string basiccoefficient { get; set; }
        public string basickeyEvents { get; set; }
        public string basicmeasurementunits { get; set; }
        public string basicmetric { get; set; }
        public string basicimperial { get; set; }
        public string basiccompare { get; set; }
        public string playertransferHistory { get; set; }
        public string playertournamentAppearances { get; set; }
        public string playertransferFee { get; set; }
        public string playercurrentPlayerValue { get; set; }
        public string playersummaryLast12 { get; set; }
        public string playerloan { get; set; }
        public string playersummaryNumber { get; set; }
        public string playersummaryAvg { get; set; }
        public string playertransferLoan { get; set; }
        public string playerinjuryPeriod { get; set; }
        public string playerendOfLoan { get; set; }
        public string playertransfer { get; set; }
        public string playertransferfree { get; set; }
        public string playertransferunknown { get; set; }
        public string playerpositionunknown { get; set; }
        public string playerendOfCareer { get; set; }
        public string playerdraft { get; set; }
        public string playerreleased { get; set; }
        public string playersigned { get; set; }
        public string playerisValueHigher { get; set; }
        public string playerthanksForContribution { get; set; }
        public string playerfrom { get; set; }
        public string playerdraftInfo { get; set; }
        public string playercomparesearchPlaceholder { get; set; }
        public string playercomparenoMatch { get; set; }
        public string playerdetailsreceiveNotifications { get; set; }
        public string eventdetailsreceiveNotifications { get; set; }
        public string playershirtNumber { get; set; }
        public string playervalue { get; set; }
        public string playerseasonalHeatMap { get; set; }
        public string playerseasonalShootMap { get; set; }
        public string playernoStatistics { get; set; }
        public string playerdidNotPlay { get; set; }
        public string playershootmaptotal { get; set; }
        public string playershootmapmade { get; set; }
        public string playershootmapmissed { get; set; }
        public string shot_map_description { get; set; }
        public string playercharacteristicsanchorPlay { get; set; }
        public string playercharacteristicspenaltyTaking { get; set; }
        public string playercharacteristicsdirectFreeKicks { get; set; }
        public string playercharacteristicslongShots { get; set; }
        public string playercharacteristicsfinishing { get; set; }
        public string playercharacteristicspassing { get; set; }
        public string playercharacteristicsplaymaking { get; set; }
        public string playercharacteristicstackling { get; set; }
        public string playercharacteristicsballInterception { get; set; }
        public string playercharacteristicsconsistency { get; set; }
        public string playercharacteristicscrossing { get; set; }
        public string playercharacteristicslongBalls { get; set; }
        public string playercharacteristicsballControl { get; set; }
        public string playercharacteristicsgroundDuels { get; set; }
        public string playercharacteristicsaerialDuels { get; set; }
        public string playercharacteristicserrorProneness { get; set; }
        public string playercharacteristicsDiscipline { get; set; }
        public string playercharacteristicspenaltySaving { get; set; }
        public string playercharacteristicsreflexes { get; set; }
        public string playercharacteristicsrunsOut { get; set; }
        public string playercharacteristicshighClaims { get; set; }
        public string playercharacteristicshandling { get; set; }
        public string playercharacteristicslongShotsSaving { get; set; }
        public string playercharacteristicspositioning { get; set; }
        public string playercharacteristicshighPressing { get; set; }
        public string playernationalTeam { get; set; }
        public string livescore { get; set; }
        public string footballlivescore { get; set; }
        public string appInstallcontinueIn { get; set; }
        public string sportListbannertitle { get; set; }
        public string sportListbannerfeaturechat { get; set; }
        public string sportListbannerfeatureplayerTransfers { get; set; }
        public string sportListbannerfeaturesyncedAccount { get; set; }
        public string sportListbannerfeaturebattleDraft { get; set; }
        public string sportListbannerfeaturebuzzer { get; set; }
        public string sportListbannerfeaturetvSchedule { get; set; }
        public string editorbannertitle { get; set; }
        public string editorbannerfootnotes { get; set; }
        public string editoreventbannertitle { get; set; }
        public string editoreventbannerlink { get; set; }
        public string fastestLap { get; set; }
        public string fastestLaplabel { get; set; }
        public string errorpageNotFound { get; set; }
        public string errorsomethingWentWrong { get; set; }
        public string erroranErrorOccurred { get; set; }
        public string errorpageCannotBeFound { get; set; }
        public string errorsomethingWrongWithPage { get; set; }
        public string errorbackToSofascore { get; set; }
        public string errorgeneric { get; set; }
        public string errorgeneric2 { get; set; }
        public string oddsdecimal { get; set; }
        public string oddsfractional { get; set; }
        public string oddsamerican { get; set; }
        public string overtimeN { get; set; }
        public string formprematchStandings { get; set; }
        public string fixturesembedCTA { get; set; }
        public string cupTreeembedcta { get; set; }
        public string cupTreeembedbackLink { get; set; }
        public string standingsLast5 { get; set; }
        public string standingsoverall { get; set; }
        public string standingshome { get; set; }
        public string standingsaway { get; set; }
        public string standingsshort { get; set; }
        public string standingsfull { get; set; }
        public string standingsform { get; set; }
        public string standingsappearance { get; set; }
        public string standingsappearanceselect { get; set; }
        public string standingsliveTable { get; set; }
        public string standingsembedCTA { get; set; }
        public string standingsembedcta { get; set; }
        public string standingsembedbackLink { get; set; }
        public string standingspromotionInfo { get; set; }
        public string standings_placeholder_data { get; set; }
        public string Pts { get; set; }
        public string WL { get; set; }
        public string standingslabelwins { get; set; }
        public string standingslabeldraws { get; set; }
        public string standingslabellosses { get; set; }
        public string standingslabelmatches { get; set; }
        public string standingslabelpct { get; set; }
        public string standingslabeldiff { get; set; }
        public string standingslabelgamesBehind { get; set; }
        public string standingslabelovertimeWins { get; set; }
        public string standingslabelovertimeLosses { get; set; }
        public string standingslabelstreak { get; set; }
        public string standingslabelpenaltyWins { get; set; }
        public string standingslabelpenaltyLosses { get; set; }
        public string standingslabelovertimeAndPenaltyWins { get; set; }
        public string standingslabelovertimeAndPenaltyLosses { get; set; }
        public string standingslabelscoresFor { get; set; }
        public string standingslabelscoresAgainst { get; set; }
        public string standingslabelsecondaryScoresFor { get; set; }
        public string standingslabelsecondaryScoresAgainst { get; set; }
        public string standingslabeloversFor { get; set; }
        public string standingslabelsets { get; set; }
        public string standingslabelsetsRatio { get; set; }
        public string standingslabeloversAgainst { get; set; }
        public string standingslabelnetRunRate { get; set; }
        public string standingslabelthreePoints { get; set; }
        public string standingslabeltwoPoints { get; set; }
        public string standingslabelonePoint { get; set; }
        public string standingslabelzeroPoints { get; set; }
        public string standingslabelnoResult { get; set; }
        public string standingslabellatest { get; set; }
        public string controlsadd { get; set; }
        public string controlssignout { get; set; }
        public string controlsmore { get; set; }
        public string controlsshowMore { get; set; }
        public string controlsshowLess { get; set; }
        public string controlsshowAll { get; set; }
        public string age { get; set; }
        public string allRounds { get; set; }
        public string knockout { get; set; }
        public string abbreviations { get; set; }
        public string abbrwc { get; set; }
        public string abbrpr { get; set; }
        public string abbrqp { get; set; }
        public string abbrll { get; set; }
        public string abbra { get; set; }
        public string abbrse { get; set; }
        public string valueM { get; set; }
        public string valueK { get; set; }
        public string cricketscorecard { get; set; }
        public string cricketovers { get; set; }
        public string cricketbatter { get; set; }
        public string cricketbowler { get; set; }
        public string legend { get; set; }
        public string cricketdidNotBat { get; set; }
        public string cricketfallOfWicket { get; set; }
        public string cricketbowlersErrors { get; set; }
        public string cricketdsr { get; set; }
        public string cricketpbp { get; set; }
        public string cricketpbpdesc { get; set; }
        public string cricket_overs_empty_state { get; set; }
        public string cricketoverdetails { get; set; }
        public string cricketwagonwheel { get; set; }
        public string cricketwagonwheelph { get; set; }
        public string cricketwagonwheeldesc { get; set; }
        public string cricketwagonwheelextra { get; set; }
        public string cricket_ww_appearance { get; set; }
        public string cricket_ww_detailedgraph { get; set; }
        public string cricket_singles_and_threes { get; set; }
        public string cricketzonename { get; set; }
        public string cricketzonelc { get; set; }
        public string cricketzonesqc { get; set; }
        public string cricketzonectd { get; set; }
        public string cricketzonecd { get; set; }
        public string cricketzoneofd { get; set; }
        public string cricketzonesd { get; set; }
        public string cricketzoneod { get; set; }
        public string cricketzonep { get; set; }
        public string cricketzoneh { get; set; }
        public string cricketzonelg { get; set; }
        public string cricketzoneg { get; set; }
        public string cricketinningnum { get; set; }
        public string cricket_current_run_rate { get; set; }
        public string cricket_target_run_rate { get; set; }
        public string tournamentleagueInfo { get; set; }
        public string tournamenttitles { get; set; }
        public string tournamenttitleHolder { get; set; }
        public string tournamenttopPlayers { get; set; }
        public string tournamenttopTeams { get; set; }
        public string tournamenttopStatsTitle { get; set; }
        public string tournamenttopStatsOnboardingText { get; set; }
        public string tournamentstandings { get; set; }
        public string tournamentpowerRankings { get; set; }
        public string tournamentfeaturedEvent { get; set; }
        public string tournamentcupTree { get; set; }
        public string tournamentteamOfTheWeek { get; set; }
        public string tournamentmostTitles { get; set; }
        public string tournamentsameDivision { get; set; }
        public string tournamentnewcomersOther { get; set; }
        public string tournamentupperDivision { get; set; }
        public string tournamentnewComersUpperDivision { get; set; }
        public string tournamentlowerDivision { get; set; }
        public string tournamentnewComersLowerDivision { get; set; }
        public string tournamentfacts { get; set; }
        public string tournamenthost { get; set; }
        public string tournamentseries { get; set; }
        public string tournamenttotwembedCTA { get; set; }
        public string tournamenttotwbackLink { get; set; }
        public string tournamenttotwsecondLeg { get; set; }
        public string tournamentreceiveNotifications { get; set; }
        public string performance_chart { get; set; }
        public string performance_chart_info_league { get; set; }
        public string performance_chart_info_team { get; set; }
        public string performance_chart_onboarding { get; set; }
        public string performance_chart_empty_season { get; set; }
        public string performance_chart_team_select { get; set; }
        public string performance_chart_info_match { get; set; }
        public string performance_chart_no_matches { get; set; }
        public string performance_chart_team_one { get; set; }
        public string performance_chart_team_two { get; set; }
        public string nextMatchesToBeDetermined { get; set; }
        public string byDate { get; set; }
        public string byRound { get; set; }
        public string byGroup { get; set; }
        public string date { get; set; }
        public string week { get; set; }
        public string _out { get; set; }
        public string assist { get; set; }
        public string ordinalAssist { get; set; }
        public string injuryTime { get; set; }
        public string statsperGame { get; set; }
        public string statsper90 { get; set; }
        public string statsallPlayers { get; set; }
        public string statsage { get; set; }
        public string statsappearances { get; set; }
        public string statsaccumulation { get; set; }
        public string statsposition { get; set; }
        public string statspreferredFoot { get; set; }
        public string statsplayersWithMinApps { get; set; }
        public string statsplayersWithMinAppsDescription { get; set; }
        public string statsmoreThan { get; set; }
        public string statslessThan { get; set; }
        public string statsequals { get; set; }
        public string statsboth { get; set; }
        public string statsgoalkeepers { get; set; }
        public string statsdefenders { get; set; }
        public string statsmidfielders { get; set; }
        public string statsforwards { get; set; }
        public string statschoose { get; set; }
        public string statsmillion { get; set; }
        public string statsmillionShort { get; set; }
        public string statssummary { get; set; }
        public string statsdetailed { get; set; }
        public string statsgoalkeeper { get; set; }
        public string statsattack { get; set; }
        public string statsdefence { get; set; }
        public string statspassing { get; set; }
        public string statsclearFilters { get; set; }
        public string statsnoResults { get; set; }
        public string statsduels { get; set; }
        public string statustoday { get; set; }
        public string statusfinalResultOnly { get; set; }
        public string statusafter { get; set; }
        public string awarded { get; set; }
        public string searchresultsFor { get; set; }
        public string searchresultsForQuery { get; set; }
        public string searchnoResults { get; set; }
        public string searchqueryTooShort { get; set; }
        public string sofaratings { get; set; }
        public string sofaratingsAndHeatmap { get; set; }
        public string sofastatisticalRatings { get; set; }
        public string streaksheadToHeadStreaks { get; set; }
        public string streaksteamStreaks { get; set; }
        public string sportselectsport { get; set; }
        public string sportamericanfootball { get; set; }
        public string sportaussierules { get; set; }
        public string sportbadminton { get; set; }
        public string sportbandy { get; set; }
        public string sportbaseball { get; set; }
        public string sportbasketball { get; set; }
        public string sportbeachvolley { get; set; }
        public string sportcricket { get; set; }
        public string sportcycling { get; set; }
        public string sportdarts { get; set; }
        public string sportfloorball { get; set; }
        public string sportfootball { get; set; }
        public string sportfutsal { get; set; }
        public string sporthandball { get; set; }
        public string sporticehockey { get; set; }
        public string sportmotorsport { get; set; }
        public string sportrugby { get; set; }
        public string sportsnooker { get; set; }
        public string sporttabletennis { get; set; }
        public string sporttennis { get; set; }
        public string sportvolleyball { get; set; }
        public string sportwaterpolo { get; set; }
        public string sportesports { get; set; }
        public string sportmma { get; set; }
        public string new_sport { get; set; }
        public string titlemain { get; set; }
        public string titlelivescore { get; set; }
        public string titlelivescorev3 { get; set; }
        public string titlelivescoreesports { get; set; }
        public string titlelivescoretennis { get; set; }
        public string titleeventeuro2020 { get; set; }
        public string titlefavorites { get; set; }
        public string titlestandings { get; set; }
        public string titlesearch { get; set; }
        public string titleuserprofile { get; set; }
        public string titleuserlogin { get; set; }
        public string titleuserlogout { get; set; }
        public string titlerankings { get; set; }
        public string titlemotorsport { get; set; }
        public string titlemotorsportstage { get; set; }
        public string titlecycling { get; set; }
        public string titlecyclingstage { get; set; }
        public string titleplayer { get; set; }
        public string titlebetting { get; set; }
        public string titlereferee { get; set; }
        public string titleuteuro { get; set; }
        public string titledriver { get; set; }
        public string titlestandingstabletennis { get; set; }
        public string titleutworldCup { get; set; }
        public string wchistorytitle { get; set; }
        public string wcstatstitle { get; set; }
        public string wcstatspromo { get; set; }
        public string substitutionout { get; set; }
        public string substitutionin { get; set; }
        public string usersignIn { get; set; }
        public string usersignInMessage { get; set; }
        public string usersignInToSofascore { get; set; }
        public string userlogIn { get; set; }
        public string usercreateNewAccount { get; set; }
        public string userexistingAccount { get; set; }
        public string usercontinueWith { get; set; }
        public string userwelcomeBack { get; set; }
        public string usersignOut { get; set; }
        public string useremailPlaceholder { get; set; }
        public string userlogoutMessage { get; set; }
        public string userunsubscribe { get; set; }
        public string userunsubscribeMessage { get; set; }
        public string userdeleteAccountTitle { get; set; }
        public string userdeleteAccountMessage { get; set; }
        public string userdeleteAccount { get; set; }
        public string userconfirmDelete { get; set; }
        public string usernotFound { get; set; }
        public string userloginloading { get; set; }
        public string team_event_shot_map_description { get; set; }
        public string teamshotmaplegendnoShots { get; set; }
        public string imgclickswap { get; set; }
        public string teameventshotmap { get; set; }
        public string nationality { get; set; }
        public string nationalityshort { get; set; }
        public string yearsshort { get; set; }
        public string games { get; set; }
        public string deceasedYear { get; set; }
        public string squad { get; set; }
        public string coach { get; set; }
        public string players { get; set; }
        public string playerstrengths { get; set; }
        public string playerweaknesses { get; set; }
        public string playerprofile { get; set; }
        public string playerstatistics { get; set; }
        public string playerdetails { get; set; }
        public string playerinfoattributeOverview { get; set; }
        public string playerinfoattributeOverviewDescription { get; set; }
        public string playerinfonoAttributeOverview { get; set; }
        public string playerinfolegendDescriptionAvg { get; set; }
        public string playerinfolegendDescriptionCmp { get; set; }
        public string playerinfolegendDescriptionHist { get; set; }
        public string playerinfonoOutstanding { get; set; }
        public string playerinfopenaltyConversion { get; set; }
        public string playerinfopenaltiesScored { get; set; }
        public string playerembedaddPlayer { get; set; }
        public string playerInfoplays { get; set; }
        public string playerInfofullambidextrous { get; set; }
        public string playerInfofullrighthanded { get; set; }
        public string playerInfofulllefthanded { get; set; }
        public string playerInfoturnedPro { get; set; }
        public string playerInfothisYear { get; set; }
        public string playerInfocareerTotal { get; set; }
        public string playerretired { get; set; }
        public string playernoTeam { get; set; }
        public string playeraverageRating { get; set; }
        public string playerswapSummaryValues { get; set; }
        public string playerswapBasketballAreaValues { get; set; }
        public string embeddlbuttontext { get; set; }
        public string team { get; set; }
        public string teams { get; set; }
        public string leagues { get; set; }
        public string ridersbikes { get; set; }
        public string riderscycling { get; set; }
        public string drivers { get; set; }
        public string driverinfo { get; set; }
        public string driverreceiveNotifications { get; set; }
        public string helmetnumber { get; set; }
        public string gpstarts { get; set; }
        public string yearposition { get; set; }
        public string teamformDescription { get; set; }
        public string teamformHeaderDescription { get; set; }
        public string tournaments { get; set; }
        public string myFavourites { get; set; }
        public string editFavourites { get; set; }
        public string favoritesemptyStateTitle { get; set; }
        public string favoritesemptyStateDescription { get; set; }
        public string favoritesemptyStateCTA { get; set; }
        public string favoritesentitySuggestion { get; set; }
        public string favoritesbecauseYouFollow { get; set; }
        public string favoritesnoFollowedEvents { get; set; }
        public string favoritesmuteEvent { get; set; }
        public string favoritesfollowEditor { get; set; }
        public string favoritesdeleteFinishedConfirmation { get; set; }
        public string remove_from_favourites { get; set; }
        public string favoritesgroupByLeague { get; set; }
        public string favoritesdeleteFinished { get; set; }
        public string notificationssettings { get; set; }
        public string notificationscurrentlyDisabled { get; set; }
        public string start { get; set; }
        public string halftime { get; set; }
        public string finish { get; set; }
        public string media { get; set; }
        public string reminder { get; set; }
        public string lineups { get; set; }
        public string advantage { get; set; }
        public string boxScore { get; set; }
        public string starter { get; set; }
        public string finished { get; set; }
        public string boxScoreAppearance { get; set; }
        public string boxScoreFull { get; set; }
        public string probable_pitchers { get; set; }
        public string probable_pitchers_empty { get; set; }
        public string goalscorer { get; set; }
        public string penaltyMissed { get; set; }
        public string performanceRelated { get; set; }
        public string singleLeg { get; set; }
        public string twoLegs { get; set; }
        public string score { get; set; }
        public string scoreset { get; set; }
        public string scorecricket { get; set; }
        public string scorecricketShort { get; set; }
        public string coverageCanceled { get; set; }
        public string periodStart { get; set; }
        public string periodStartcricket { get; set; }
        public string periodScorefloorball { get; set; }
        public string quarterstart { get; set; }
        public string quarterresult { get; set; }
        public string tennispreviousTournaments { get; set; }
        public string tennisbrake { get; set; }
        public string eventliveAction { get; set; }
        public string eventliveTwitterFeed { get; set; }
        public string eventallRated { get; set; }
        public string bestRatedFanMatches { get; set; }
        public string eventrateThisMatch { get; set; }
        public string eventfansRated { get; set; }
        public string eventtennisPower { get; set; }
        public string eventtennisPowerabout { get; set; }
        public string eventtennisPowertitle { get; set; }
        public string eventtennisPowerdescription { get; set; }
        public string eventtennisPowerlowLevel { get; set; }
        public string eventtennisPowerhighLevel { get; set; }
        public string eventtennisPowerbreakWon { get; set; }
        public string eventtitle { get; set; }
        public string eventaggregatedWin { get; set; }
        public string eventaggregated { get; set; }
        public string eventseries { get; set; }
        public string eventcreatedBy { get; set; }
        public string eventeditedBy { get; set; }
        public string eventattackMomentumCTA { get; set; }
        public string eventembedlineupsBackLink { get; set; }
        public string eventcoverageDowngradeInfo { get; set; }
        public string eventlineupsCTA { get; set; }
        public string eventfirstLeg { get; set; }
        public string eventpreviousMatch { get; set; }
        public string eventabout { get; set; }
        public string eventabout1 { get; set; }
        public string eventabout2 { get; set; }
        public string eventabout3 { get; set; }
        public string eventaboutmoreDetails { get; set; }
        public string eventaboutteamLink { get; set; }
        public string eventabout4 { get; set; }
        public string eventaboutschema { get; set; }
        public string eventaboutnew { get; set; }
        public string eventaboutnew2 { get; set; }
        public string eventaboutnew3 { get; set; }
        public string eventaboutnew4 { get; set; }
        public string eventaboutnew5 { get; set; }
        public string eventaboutnew6 { get; set; }
        public string eventaboutnew7 { get; set; }
        public string eventaboutnew8 { get; set; }
        public string eventaboutnew9 { get; set; }
        public string eventaboutnew10 { get; set; }
        public string eventaboutnew11 { get; set; }
        public string eventaboutnew12 { get; set; }
        public string eventimportantNotice { get; set; }
        public string eventimportantNotice1 { get; set; }
        public string eventimportantNotice2 { get; set; }
        public string eventaboutesports1 { get; set; }
        public string eventaboutesports2 { get; set; }
        public string eventaboutesports3 { get; set; }
        public string eventaboutesports3name { get; set; }
        public string eventaboutesports4 { get; set; }
        public string eventaboutesports5 { get; set; }
        public string eventaboutesports6 { get; set; }
        public string eventaboutesports7 { get; set; }
        public string eventaboutesports8 { get; set; }
        public string eventaboutesports9 { get; set; }
        public string eventaboutesports10 { get; set; }
        public string eventaboutstreamNotAvailable { get; set; }
        public string eventtennisabout1 { get; set; }
        public string eventtennisabout2 { get; set; }
        public string eventtennisaboutbullet1 { get; set; }
        public string eventtennisaboutbullet2 { get; set; }
        public string eventtennisaboutbullet3 { get; set; }
        public string eventtennisaboutbullet4 { get; set; }
        public string eventtennisaboutbullet5 { get; set; }
        public string eventtennisaboutbullet6 { get; set; }
        public string eventtennisabout3 { get; set; }
        public string eventtennisabout4 { get; set; }
        public string eventplayAreasconcentrationhigh { get; set; }
        public string eventplayAreasconcentrationlow { get; set; }
        public string eventstatusReason { get; set; }
        public string eventtvChannelsnoVotes { get; set; }
        public string commentary_title { get; set; }
        public string commentary_goal { get; set; }
        public string commentary_injury_return { get; set; }
        public string commentary_var_check_over { get; set; }
        public string commentary_touchdown { get; set; }
        public string commentary_field_goal { get; set; }
        public string commentary_missed_field_goal { get; set; }
        public string commentary_extra_point { get; set; }
        public string commentary_two_pt_conversion { get; set; }
        public string commentary_safety { get; set; }
        public string commentary_fumble { get; set; }
        public string commentary_turnover_on_downs { get; set; }
        public string commentary_4th_down_conversion { get; set; }
        public string commentary_yards_run { get; set; }
        public string commentary_yards_passed { get; set; }
        public string commentary_interception { get; set; }
        public string commentary_interception_return { get; set; }
        public string commentary_extra_point_attempt { get; set; }
        public string commentary_two_minute_warning { get; set; }
        public string missingplayerstitle { get; set; }
        public string missingplayersnomissingplayers { get; set; }
        public string missingplayerdoubtful { get; set; }
        public string missingplayermissing { get; set; }
        public string missingplayersuspended { get; set; }
        public string missingplayeronloan { get; set; }
        public string lineupsaverageAge { get; set; }
        public string lineupsratingsInfo { get; set; }
        public string lineupsshareLineups { get; set; }
        public string esportsbestOf { get; set; }
        public string notification_off_allow_favourites { get; set; }
        public string referee { get; set; }
        public string refereecareerStatistic { get; set; }
        public string refereecareerStatisticinfoTitle { get; set; }
        public string refereecareerStatisticappearances { get; set; }
        public string refereecareerStatisticappearancesshort { get; set; }
        public string refereecareerStatisticyellowCardsPerGame { get; set; }
        public string refereecareerStatisticyellowCardsPerGameshort { get; set; }
        public string refereecareerStatisticredCards { get; set; }
        public string refereecareerStatisticredCardsshort { get; set; }
        public string refereecareerStatisticpenalty { get; set; }
        public string refereecareerStatisticpenaltyshort { get; set; }
        public string refereecompetitions { get; set; }
        public string manager { get; set; }
        public string managers { get; set; }
        public string managercareerHistory { get; set; }
        public string managerprofile { get; set; }
        public string managercareer { get; set; }
        public string manageraveragePointsDescription { get; set; }
        public string manageraveragePointsTotalDescription { get; set; }
        public string managerabout { get; set; }
        public string managerpointsPerMatch { get; set; }
        public string managerpointsPerMatchLong { get; set; }
        public string managerprefFormation { get; set; }
        public string managerperformance { get; set; }
        public string managertotalMatches { get; set; }
        public string managerwins { get; set; }
        public string managerdraws { get; set; }
        public string managerlosses { get; set; }
        public string attackMomentumabout { get; set; }
        public string attackMomentumhomePressure { get; set; }
        public string attackMomentumawayPressure { get; set; }
        public string attackMomentumclickOnGraph { get; set; }
        public string pickemageQuestion { get; set; }
        public string pickemageUnder { get; set; }
        public string pickemexpired { get; set; }
        public string pickemrulesInfo { get; set; }
        public string pickemcontinue { get; set; }
        public string pickemsubmitDisclaimer { get; set; }
        public string pickemnameAndSurname { get; set; }
        public string pickememail { get; set; }
        public string pickemrequiredFields { get; set; }
        public string pickemsubmit { get; set; }
        public string pickemsubmitted { get; set; }
        public string pickemsubmittedDescription { get; set; }
        public string pickemyourPreview { get; set; }
        public string pickemuserPreview { get; set; }
        public string pickemyesterday { get; set; }
        public string pickemdateAt { get; set; }
        public string pickemleaderboardButton { get; set; }
        public string pickemplayAgainButton { get; set; }
        public string pickemshareButton { get; set; }
        public string pickemleaderboardTitle { get; set; }
        public string pickemleaderboardplayer { get; set; }
        public string pickemshare { get; set; }
        public string pickemshareCopy { get; set; }
        public string pickemshareCopied { get; set; }
        public string pickemgroupDescriptionfixed { get; set; }
        public string pickemchooseWinning { get; set; }
        public string defender { get; set; }
        public string defenderLeft { get; set; }
        public string defenderCenter { get; set; }
        public string defenderRight { get; set; }
        public string defensiveMidfielder { get; set; }
        public string midfielder { get; set; }
        public string midfielderLeft { get; set; }
        public string midfielderCenter { get; set; }
        public string midfielderRight { get; set; }
        public string attackingMidfielder { get; set; }
        public string forward { get; set; }
        public string leftWinger { get; set; }
        public string rightWinger { get; set; }
        public string striker { get; set; }
        public string goalkeeper { get; set; }
        public string positionrightBackshort { get; set; }
        public string positionleftBackshort { get; set; }
        public string positioncentralBackshort { get; set; }
        public string positionpivotshort { get; set; }
        public string positiondefendershort { get; set; }
        public string positiondefenderLeftshort { get; set; }
        public string positiondefenderCentershort { get; set; }
        public string positiondefenderRightshort { get; set; }
        public string positiondefensiveMidfielder { get; set; }
        public string positionmidfieldershort { get; set; }
        public string positionmidfielderLeftshort { get; set; }
        public string positionmidfielderRightshort { get; set; }
        public string positionmidfielderCentershort { get; set; }
        public string positionattackingMidfieldershort { get; set; }
        public string positionforwardshort { get; set; }
        public string positionleftWingershort { get; set; }
        public string positionrightWingershort { get; set; }
        public string positionstrikershort { get; set; }
        public string positiongoalkeepershort { get; set; }
        public string positionbasketballcentershort { get; set; }
        public string positioncenterForwardshort { get; set; }
        public string positionbasketballforwardshort { get; set; }
        public string positionforwardCentershort { get; set; }
        public string positionforwardGuardshort { get; set; }
        public string positionguardshort { get; set; }
        public string positionguardForwardshort { get; set; }
        public string positiondefensemanshort { get; set; }
        public string positiongoalieshort { get; set; }
        public string positionhockeyshortcenter { get; set; }
        public string positionleftWingshort { get; set; }
        public string positionrightWingshort { get; set; }
        public string rightBack { get; set; }
        public string leftBack { get; set; }
        public string centralBack { get; set; }
        public string pivot { get; set; }
        public string basketballcenter { get; set; }
        public string centerForward { get; set; }
        public string basketballforward { get; set; }
        public string forwardCenter { get; set; }
        public string forwardGuard { get; set; }
        public string guard { get; set; }
        public string guardForward { get; set; }
        public string defenseman { get; set; }
        public string goalie { get; set; }
        public string hockeycenter { get; set; }
        public string leftWing { get; set; }
        public string rightWing { get; set; }
        public string positionpitchershort { get; set; }
        public string positioncatchershort { get; set; }
        public string position1stBaseshort { get; set; }
        public string position2ndBaseshort { get; set; }
        public string position3rdBaseshort { get; set; }
        public string positionshortstopshort { get; set; }
        public string positionleftFieldshort { get; set; }
        public string positioncenterFieldshort { get; set; }
        public string positionrightFieldshort { get; set; }
        public string positiondesignatedHittershort { get; set; }
        public string positionstartingPitchershort { get; set; }
        public string positionclosershort { get; set; }
        public string positionpinchHittershort { get; set; }
        public string positionpinchRunnershort { get; set; }
        public string positionbaseRunnershort { get; set; }
        public string positionoutfieldshort { get; set; }
        public string positioninfieldshort { get; set; }
        public string positionreliefPitchershort { get; set; }
        public string positionutilshort { get; set; }
        public string positionutilInfieldershort { get; set; }
        public string positionutilOutfieldershort { get; set; }
        public string positionrhPitchershort { get; set; }
        public string positionlhPitchershort { get; set; }
        public string positionrhStartedshort { get; set; }
        public string positionlhStartershort { get; set; }
        public string positionlhRelievershort { get; set; }
        public string positionrhRelievershort { get; set; }
        public string positionbattershort { get; set; }
        public string pitcher { get; set; }
        public string catcher { get; set; }
        public string _1stBase { get; set; }
        public string _2ndBase { get; set; }
        public string _3rdBase { get; set; }
        public string shortstop { get; set; }
        public string leftField { get; set; }
        public string centerField { get; set; }
        public string rightField { get; set; }
        public string designatedHitter { get; set; }
        public string startingPitcher { get; set; }
        public string closer { get; set; }
        public string pinchHitter { get; set; }
        public string hitter { get; set; }
        public string pinchRunner { get; set; }
        public string baseRunner { get; set; }
        public string runner { get; set; }
        public string outfield { get; set; }
        public string infield { get; set; }
        public string reliefPitcher { get; set; }
        public string util { get; set; }
        public string utilInfielder { get; set; }
        public string utilOutfielder { get; set; }
        public string rhPitcher { get; set; }
        public string lhPitcher { get; set; }
        public string rhStarted { get; set; }
        public string lhStarter { get; set; }
        public string lhReliever { get; set; }
        public string rhReliever { get; set; }
        public string batter { get; set; }
        public string positionpuntershort { get; set; }
        public string positionpuntReturnershort { get; set; }
        public string positionlongSnappershort { get; set; }
        public string positionkickershort { get; set; }
        public string positiontackleshort { get; set; }
        public string positionoffensiveTackleshort { get; set; }
        public string positionoffensiveLinemanshort { get; set; }
        public string positionoffensiveGuardshort { get; set; }
        public string positionamfguardshort { get; set; }
        public string positionamfcentershort { get; set; }
        public string positionquarterbackshort { get; set; }
        public string positionrunningBackshort { get; set; }
        public string positionfullbackshort { get; set; }
        public string positiontightEndshort { get; set; }
        public string positionwideReceivershort { get; set; }
        public string positionstrongSafetyshort { get; set; }
        public string positionsafetyshort { get; set; }
        public string positionfreeSafetyshort { get; set; }
        public string positiondefensiveLinemanshort { get; set; }
        public string positiondefensiveBackshort { get; set; }
        public string positioncornerBackshort { get; set; }
        public string positionnoseTackleshort { get; set; }
        public string positiondefensiveTackleshort { get; set; }
        public string positiondefensiveEndshort { get; set; }
        public string positionoutsideLinebackershort { get; set; }
        public string positionmiddleLinebackershort { get; set; }
        public string positionlinebackershort { get; set; }
        public string positioninsideLinebackershort { get; set; }
        public string punter { get; set; }
        public string puntReturner { get; set; }
        public string longSnapper { get; set; }
        public string kicker { get; set; }
        public string tackle { get; set; }
        public string offensiveTackle { get; set; }
        public string offensiveLineman { get; set; }
        public string offensiveGuard { get; set; }
        public string amfguard { get; set; }
        public string amfcenter { get; set; }
        public string quarterback { get; set; }
        public string runningBack { get; set; }
        public string fullback { get; set; }
        public string tightEnd { get; set; }
        public string wideReceiver { get; set; }
        public string strongSafety { get; set; }
        public string safety { get; set; }
        public string freeSafety { get; set; }
        public string defensiveLineman { get; set; }
        public string defensiveBack { get; set; }
        public string cornerBack { get; set; }
        public string noseTackle { get; set; }
        public string defensiveTackle { get; set; }
        public string defensiveEnd { get; set; }
        public string outsideLinebacker { get; set; }
        public string middleLinebacker { get; set; }
        public string linebacker { get; set; }
        public string insideLinebacker { get; set; }
        public string positionbatter { get; set; }
        public string positionallrounder { get; set; }
        public string positionwicketkeeper { get; set; }
        public string positionbowler { get; set; }
        public string americanFootballoffense { get; set; }
        public string americanFootballdefense { get; set; }
        public string americanFootballspecialTeam { get; set; }
        public string handballgoalkeeper { get; set; }
        public string handballback { get; set; }
        public string handballwinger { get; set; }
        public string handballpivot { get; set; }
        public string attacking { get; set; }
        public string technical { get; set; }
        public string tactical { get; set; }
        public string defending { get; set; }
        public string creativity { get; set; }
        public string anticipation { get; set; }
        public string ballDistribution { get; set; }
        public string aerial { get; set; }
        public string anchorPlay { get; set; }
        public string penaltyTaking { get; set; }
        public string directFreeKicks { get; set; }
        public string longShots { get; set; }
        public string finishing { get; set; }
        public string passing { get; set; }
        public string kicking { get; set; }
        public string playmaking { get; set; }
        public string tackling { get; set; }
        public string ballInterception { get; set; }
        public string consistency { get; set; }
        public string crossing { get; set; }
        public string ballControl { get; set; }
        public string groundDuels { get; set; }
        public string aerialDuels { get; set; }
        public string errorProneness { get; set; }
        public string discipline { get; set; }
        public string penaltySaving { get; set; }
        public string reflexes { get; set; }
        public string runsOut { get; set; }
        public string handling { get; set; }
        public string longShotsSaving { get; set; }
        public string positioning { get; set; }
        public string highPressing { get; set; }
        public string footright { get; set; }
        public string footleft { get; set; }
        public string footboth { get; set; }
        public string handshortright { get; set; }
        public string handshortleft { get; set; }
        public string expectedGoals { get; set; }
        public string expectedGoalsScored { get; set; }
        public string stat_xa_assisted { get; set; }
        public string football_expected_assists { get; set; }
        public string football_goals_prevented { get; set; }
        public string football_free_kicks { get; set; }
        public string football_throw_ins { get; set; }
        public string football_goal_kicks { get; set; }
        public string avgRating { get; set; }
        public string averageBallPossession { get; set; }
        public string penaltyGoalsConceded { get; set; }
        public string pointsAgainst { get; set; }
        public string pointsWon { get; set; }
        public string statpg { get; set; }
        public string servicePointsWon { get; set; }
        public string receiverPointsWon { get; set; }
        public string servicePointsWonExpedite { get; set; }
        public string receiverPointsWonExpedite { get; set; }
        public string numberOfLets { get; set; }
        public string aces { get; set; }
        public string maxPointsInARow { get; set; }
        public string serviceErrors { get; set; }
        public string ballPossession { get; set; }
        public string totalShots { get; set; }
        public string totalShotsPerGame { get; set; }
        public string shotsOnTarget { get; set; }
        public string shotsOffTarget { get; set; }
        public string shotsOnTargetPerGame { get; set; }
        public string shotsOffTargetPerGame { get; set; }
        public string blockedShots { get; set; }
        public string blockedShotsPerGame { get; set; }
        public string cornerKicks { get; set; }
        public string offsides { get; set; }
        public string offsidesPerGame { get; set; }
        public string fouls { get; set; }
        public string foulsPerGame { get; set; }
        public string yellowCards { get; set; }
        public string yellowCardsPerGame { get; set; }
        public string redCards { get; set; }
        public string bigChances { get; set; }
        public string bigChancesMissed { get; set; }
        public string bigChancesPerGame { get; set; }
        public string bigChancesMissedPerGame { get; set; }
        public string hitWoodwork { get; set; }
        public string counterAttacks { get; set; }
        public string counterAttackShots { get; set; }
        public string counterAttackGoals { get; set; }
        public string shotsInsideBox { get; set; }
        public string shotsOutsideBox { get; set; }
        public string goalkeeperSaves { get; set; }
        public string passes { get; set; }
        public string accuratePasses { get; set; }
        public string longBalls { get; set; }
        public string crosses { get; set; }
        public string dribbles { get; set; }
        public string dispossessed { get; set; }
        public string duelsWon { get; set; }
        public string duelsWonPerGame { get; set; }
        public string aerialsWon { get; set; }
        public string tackles { get; set; }
        public string goalsAssistsSum { get; set; }
        public string interceptions { get; set; }
        public string clearances { get; set; }
        public string successfulDribbles { get; set; }
        public string successfulDribblesPerGame { get; set; }
        public string successfulDribblesPercentage { get; set; }
        public string goalConversionPercentage { get; set; }
        public string inaccuratePasses { get; set; }
        public string totalPasses { get; set; }
        public string accuratePassesPercentage { get; set; }
        public string accurateOwnHalfPasses { get; set; }
        public string accurateOppositionHalfPasses { get; set; }
        public string accurateFinalThirdPasses { get; set; }
        public string accurateCrosses { get; set; }
        public string accurateCrossesPercentage { get; set; }
        public string groundDuelsWon { get; set; }
        public string groundDuelsWonPercentage { get; set; }
        public string aerialDuelsWon { get; set; }
        public string aerialDuelsWonPercentage { get; set; }
        public string totalDuelsWon { get; set; }
        public string totalDuelsWonPercentage { get; set; }
        public string penaltiesTaken { get; set; }
        public string penaltyConceded { get; set; }
        public string penaltiesCommitted { get; set; }
        public string clearancesOffLine { get; set; }
        public string lastManTackles { get; set; }
        public string shotFromSetPiece { get; set; }
        public string freeKickGoal { get; set; }
        public string goalsFromInsideTheBox { get; set; }
        public string goalsFromOutsideTheBox { get; set; }
        public string accurateLongBalls { get; set; }
        public string accurateLongBallsPercentage { get; set; }
        public string errorLeadToGoal { get; set; }
        public string errorLeadToShot { get; set; }
        public string errorsLeadingToShot { get; set; }
        public string errorsLeadingToGoal { get; set; }
        public string possessionLost { get; set; }
        public string possessionLostPerGame { get; set; }
        public string possessionWon { get; set; }
        public string mostConceded { get; set; }
        public string leastConceded { get; set; }
        public string passToAssist { get; set; }
        public string cleanSheet { get; set; }
        public string penaltyFaced { get; set; }
        public string penaltyShootout { get; set; }
        public string penaltyShootoutSave { get; set; }
        public string penaltyShootoutGoal { get; set; }
        public string penaltyShootoutMiss { get; set; }
        public string savedShotsFromInsideTheBox { get; set; }
        public string savedShotsFromOutsideTheBox { get; set; }
        public string goalsConcededInsideTheBox { get; set; }
        public string goalsConcededOutsideTheBox { get; set; }
        public string successfulRunsOut { get; set; }
        public string crossesNotClaimed { get; set; }
        public string football_free_kicks_per_game { get; set; }
        public string football_throw_ins_per_game { get; set; }
        public string football_goal_kicks_per_game { get; set; }
        public string football_balls_recovered_per_game { get; set; }
        public string appearances { get; set; }
        public string debut { get; set; }
        public string setPieceConversion { get; set; }
        public string notes { get; set; }
        public string runs { get; set; }
        public string doubles { get; set; }
        public string triples { get; set; }
        public string homeRuns { get; set; }
        public string strikes { get; set; }
        public string strikeOuts { get; set; }
        public string strikeOutsAsBatter { get; set; }
        public string strikeOutsAsPitcher { get; set; }
        public string pitchOuts { get; set; }
        public string baseOnBalls { get; set; }
        public string runsBattedIn { get; set; }
        public string caughtStealing { get; set; }
        public string stolenBases { get; set; }
        public string sacrificeBunts { get; set; }
        public string sacrificeFly { get; set; }
        public string battingAverage { get; set; }
        public string earnedRunsAverage { get; set; }
        public string hits { get; set; }
        public string avglc { get; set; }
        public string avg { get; set; }
        public string obp { get; set; }
        public string slg { get; set; }
        public string ops { get; set; }
        public string rbi { get; set; }
        public string atBats { get; set; }
        public string leftOnBase { get; set; }
        public string era { get; set; }
        public string inningsPitched { get; set; }
        public string earnedRuns { get; set; }
        public string battersFaced { get; set; }
        public string outs { get; set; }
        public string flyOuts { get; set; }
        public string groundOuts { get; set; }
        public string assists { get; set; }
        public string putOuts { get; set; }
        public string baseballfieldingErrors { get; set; }
        public string matchPoints { get; set; }
        public string comebackToWin { get; set; }
        public string biggestLead { get; set; }
        public string freeThrows { get; set; }
        public string twoPointers { get; set; }
        public string threePointers { get; set; }
        public string fieldGoals { get; set; }
        public string rebounds { get; set; }
        public string secondsPlayed { get; set; }
        public string fieldGoalsPercentage { get; set; }
        public string fieldGoalsPercentageAgainst { get; set; }
        public string freeThrowsPercentage { get; set; }
        public string threePointsPercentage { get; set; }
        public string threePointsPercentageAgainst { get; set; }
        public string threePointsMade { get; set; }
        public string shootingPercentage { get; set; }
        public string sevenMetersScored { get; set; }
        public string twoMinutePenalties { get; set; }
        public string assistTurnoverRatio { get; set; }
        public string pir { get; set; }
        public string defensiveRebounds { get; set; }
        public string offensiveRebounds { get; set; }
        public string turnovers { get; set; }
        public string goalsAgainstAverage { get; set; }
        public string steals { get; set; }
        public string blocks { get; set; }
        public string plusMinus { get; set; }
        public string pirStat { get; set; }
        public string timeouts { get; set; }
        public string timeSpentInLead { get; set; }
        public string leadChanges { get; set; }
        public string doubleFaults { get; set; }
        public string firstServe { get; set; }
        public string secondServe { get; set; }
        public string breakPoints { get; set; }
        public string firstServePoints { get; set; }
        public string secondServePoints { get; set; }
        public string touchdowns { get; set; }
        public string amffieldGoals { get; set; }
        public string passingTouchdownInterceptionRatio { get; set; }
        public string totalYards { get; set; }
        public string amfturnovers { get; set; }
        public string rushingYards { get; set; }
        public string redZoneEfficiency { get; set; }
        public string timeOfPossession { get; set; }
        public string firstDowns { get; set; }
        public string firstDownsRushing { get; set; }
        public string firstDownsPassing { get; set; }
        public string firstDownsPenalty { get; set; }
        public string thirdDownEfficiency { get; set; }
        public string netYardsPassing { get; set; }
        public string grossYardsPassing { get; set; }
        public string passingAndInterceptions { get; set; }
        public string punts { get; set; }
        public string averageYardsPerPunt { get; set; }
        public string amfpenalties { get; set; }
        public string yardsPenalized { get; set; }
        public string fumbles { get; set; }
        public string fumblesLost { get; set; }
        public string shootingEfficiency { get; set; }
        public string _9mGoals { get; set; }
        public string _6mGoals { get; set; }
        public string wingGoals { get; set; }
        public string fastbreakGoals { get; set; }
        public string _7meters { get; set; }
        public string saves { get; set; }
        public string _2minPenalty { get; set; }
        public string goalStreak { get; set; }
        public string goalsInPowerplay { get; set; }
        public string shorthandedGoals { get; set; }
        public string hockeyshorthandedGoals { get; set; }
        public string technicalFaults { get; set; }
        public string tries { get; set; }
        public string conversions { get; set; }
        public string rugbypenaltyGoals { get; set; }
        public string scrums { get; set; }
        public string lineouts { get; set; }
        public string rugbyturnovers { get; set; }
        public string penaltiesConceded { get; set; }
        public string penalties { get; set; }
        public string penaltiesMissed { get; set; }
        public string goals { get; set; }
        public string shots { get; set; }
        public string faceoffsWon { get; set; }
        public string blocked { get; set; }
        public string takeaways { get; set; }
        public string giveaways { get; set; }
        public string penaltyMinutes { get; set; }
        public string minutesPlayed { get; set; }
        public string totalDribbleAttempts { get; set; }
        public string penaltyWon { get; set; }
        public string penaltyMiss { get; set; }
        public string keyPasses { get; set; }
        public string totalCrosses { get; set; }
        public string totalLongBalls { get; set; }
        public string bigChancesCreated { get; set; }
        public string touches { get; set; }
        public string clearanceOffLine { get; set; }
        public string totalTackles { get; set; }
        public string lastManTackle { get; set; }
        public string errorLedToGoal { get; set; }
        public string errorLedToShot { get; set; }
        public string ownGoals { get; set; }
        public string penaltyCommitted { get; set; }
        public string totalDuels { get; set; }
        public string totalAerialDuels { get; set; }
        public string totalGroundDuels { get; set; }
        public string dribbledPast { get; set; }
        public string wasFouled { get; set; }
        public string penaltySave { get; set; }
        public string punches { get; set; }
        public string totalRunsOut { get; set; }
        public string highClaims { get; set; }
        public string position { get; set; }
        public string positionshort { get; set; }
        public string rating { get; set; }
        public string shotsBlocked { get; set; }
        public string savesFromInsideBox { get; set; }
        public string points { get; set; }
        public string defensive { get; set; }
        public string offensive { get; set; }
        public string personalFouls { get; set; }
        public string passingAttempts { get; set; }
        public string passingCompletions { get; set; }
        public string passingYards { get; set; }
        public string passingNetYards { get; set; }
        public string longestPass { get; set; }
        public string passingInterceptions { get; set; }
        public string sacked { get; set; }
        public string am_football_sack_yards_stat { get; set; }
        public string passing_touchdowns { get; set; }
        public string interceptions_thrown { get; set; }
        public string passingYardsPerAttempt { get; set; }
        public string completionPercentage { get; set; }
        public string rushingAttempts { get; set; }
        public string rushingTouchdowns { get; set; }
        public string longestRush { get; set; }
        public string rushingYardsPerAttempt { get; set; }
        public string am_football_yacon_stat { get; set; }
        public string am_football_rushing_fd_stat { get; set; }
        public string fumblesSafety { get; set; }
        public string teammateFumbleRecoveries { get; set; }
        public string fumbleRecoveries { get; set; }
        public string fumbleReturnTouchdowns { get; set; }
        public string receivingTouchdowns { get; set; }
        public string receptions { get; set; }
        public string receiving_targets { get; set; }
        public string am_football_yac_stat { get; set; }
        public string am_football_receiving_fd_stat { get; set; }
        public string receivingYards { get; set; }
        public string longestReception { get; set; }
        public string yardsPerReception { get; set; }
        public string combineTackles { get; set; }
        public string amf_tackles { get; set; }
        public string assistTackles { get; set; }
        public string sacks { get; set; }
        public string forcedFumbles { get; set; }
        public string safeties { get; set; }
        public string interceptionsTouchdowns { get; set; }
        public string interceptionsYards { get; set; }
        public string passesDefensed { get; set; }
        public string kickReturnsTotal { get; set; }
        public string kickReturnsYards { get; set; }
        public string kickReturnsTouchdowns { get; set; }
        public string kickReturnsFumbles { get; set; }
        public string kickReturnsAvgYards { get; set; }
        public string longestKickReturns { get; set; }
        public string puntingYards { get; set; }
        public string puntingNetYards { get; set; }
        public string longestPunt { get; set; }
        public string puntsBlocked { get; set; }
        public string touchbacks { get; set; }
        public string yardsPerPunt { get; set; }
        public string puntsInside20 { get; set; }
        public string fieldGoalAttempts { get; set; }
        public string fieldGoalsMade { get; set; }
        public string fieldGoalsBlocked { get; set; }
        public string attempts20 { get; set; }
        public string made20 { get; set; }
        public string attempts30 { get; set; }
        public string made30 { get; set; }
        public string attempts40 { get; set; }
        public string made40 { get; set; }
        public string attempts50 { get; set; }
        public string made50 { get; set; }
        public string extraPointsMade { get; set; }
        public string extraPointsAttempts { get; set; }
        public string longestFieldGoalMade { get; set; }
        public string totalPoints { get; set; }
        public string kickoffTotal { get; set; }
        public string kickoffYards { get; set; }
        public string kickoffTouchbacks { get; set; }
        public string kickoffReturns { get; set; }
        public string puntReturns { get; set; }
        public string puntReturnsTotal { get; set; }
        public string puntReturnsYards { get; set; }
        public string puntReturnsAvgYards { get; set; }
        public string puntReturnsTouchdowns { get; set; }
        public string longestPuntReturn { get; set; }
        public string timeOnIce { get; set; }
        public string powerplayGoals { get; set; }
        public string powerplayAssists { get; set; }
        public string powerPlayPercentage { get; set; }
        public string faceOffPercentage { get; set; }
        public string penaltyKillPercentage { get; set; }
        public string shorthandedAssists { get; set; }
        public string hockeyblocks { get; set; }
        public string evenTimeOnIce { get; set; }
        public string powerplayTimeOnIce { get; set; }
        public string shorthandedTimeOnIce { get; set; }
        public string powerplaySaves { get; set; }
        public string shorthandedSaves { get; set; }
        public string evenSaves { get; set; }
        public string savePercentage { get; set; }
        public string shotsAgainst { get; set; }
        public string totalFaceoffs { get; set; }
        public string faceOffTakenOnly { get; set; }
        public string faceOffWins { get; set; }
        public string twoMinPenalty { get; set; }
        public string shotsReceived { get; set; }
        public string _7mSaves { get; set; }
        public string _6mSaves { get; set; }
        public string pivotSaves { get; set; }
        public string _9mSaves { get; set; }
        public string breakthroughSaves { get; set; }
        public string fastbreakSaves { get; set; }
        public string goalkeeperEfficiency { get; set; }
        public string _7mGoals { get; set; }
        public string breakthroughGoals { get; set; }
        public string pivotGoals { get; set; }
        public string attack { get; set; }
        public string defence { get; set; }
        public string other { get; set; }
        public string duels { get; set; }
        public string rushing { get; set; }
        public string receiving { get; set; }
        public string kickReturns { get; set; }
        public string punting { get; set; }
        public string fieldGoalKickers { get; set; }
        public string kickoff { get; set; }
        public string regularSeason { get; set; }
        public string playoffs { get; set; }
        public string summary { get; set; }
        public string corners { get; set; }
        public string cornersPerGame { get; set; }
        public string matchesTotal { get; set; }
        public string matchesStarted { get; set; }
        public string minutesPerGame { get; set; }
        public string goalsFrequency { get; set; }
        public string goalsPerGame { get; set; }
        public string shotsPerGame { get; set; }
        public string total_stats_short { get; set; }
        public string per_game_stats_short { get; set; }
        public string basketball_per_game_stats_title { get; set; }
        public string basketball_true_shooting_pct { get; set; }
        public string basketball_points_in_paint { get; set; }
        public string basketball_charges_drawn { get; set; }
        public string basketball_flagrant_fouls { get; set; }
        public string basketball_fouls_drawn { get; set; }
        public string basketball_effective_field_goal_pct { get; set; }
        public string basketball_assist_to_turnover_ratio { get; set; }
        public string basketball_points_off_the_bench { get; set; }
        public string basketball_fast_break_points { get; set; }
        public string basketball_technical_fouls { get; set; }
        public string basketball_field_goals_made { get; set; }
        public string basketball_field_goals_attempted { get; set; }
        public string basketball_opponent_field_goals_pct { get; set; }
        public string basketball_three_points_made { get; set; }
        public string basketball_three_points_attempted { get; set; }
        public string basketball_free_throws_made { get; set; }
        public string basketball_free_throws_attempted { get; set; }
        public string basketball_points_scored_pg { get; set; }
        public string basketball_points_allowed_pg { get; set; }
        public string basketball_assists_pg { get; set; }
        public string basketball_fg_made_pg { get; set; }
        public string basketball_fg_attempted_pg { get; set; }
        public string basketball_three_pts_made_pg { get; set; }
        public string basketball_three_pts_attempted_pg { get; set; }
        public string basketball_free_throws_made_pg { get; set; }
        public string basketball_free_throws_attempted_pg { get; set; }
        public string basketball_fast_break_pts_pg { get; set; }
        public string basketball_pts_off_the_bench_pg { get; set; }
        public string basketball_second_chance_pts_pg { get; set; }
        public string basketball_pts_in_paint_pg { get; set; }
        public string basketball_blocks_pg { get; set; }
        public string basketball_steals_pg { get; set; }
        public string basketball_charges_drawn_pg { get; set; }
        public string basketball_offensive_rebounds_pg { get; set; }
        public string basketball_defensive_rebounds_pg { get; set; }
        public string basketball_total_rebounds_pg { get; set; }
        public string basketball_total_flagrant_fouls { get; set; }
        public string basketball_total_technical_fouls { get; set; }
        public string basketball_turnovers_pg { get; set; }
        public string basketball_effective_fg_pct_info { get; set; }
        public string basketball_true_shooting_pct_info { get; set; }
        public string value { get; set; }
        public string scoringFrequency { get; set; }
        public string accuratePerGame { get; set; }
        public string succDribbles { get; set; }
        public string interceptionsPerGame { get; set; }
        public string tacklesPerGame { get; set; }
        public string dribbledPastPerGame { get; set; }
        public string yellow { get; set; }
        public string yellowRed { get; set; }
        public string red { get; set; }
        public string goalsConcededPerGame { get; set; }
        public string penaltiesSaved { get; set; }
        public string savesPerGame { get; set; }
        public string succRunsOutPerGame { get; set; }
        public string cleanSheets { get; set; }
        public string goalConversion { get; set; }
        public string penaltyGoals { get; set; }
        public string penaltyConversion { get; set; }
        public string freeKickGoals { get; set; }
        public string freeKickConversion { get; set; }
        public string goalsInsideBox { get; set; }
        public string goalsOutsideBox { get; set; }
        public string headedGoals { get; set; }
        public string leftFootGoals { get; set; }
        public string rightFootGoals { get; set; }
        public string accPassesOwnHalf { get; set; }
        public string accChippedPasses { get; set; }
        public string accPassesOppositionHalf { get; set; }
        public string accLongPasses { get; set; }
        public string goalsConceded { get; set; }
        public string goalsScored { get; set; }
        public string goalsConcededInsideBox { get; set; }
        public string goalsConcededOutsideBox { get; set; }
        public string savesMade { get; set; }
        public string savesFromOutsideBox { get; set; }
        public string savesCaught { get; set; }
        public string savesParried { get; set; }
        public string accCrosses { get; set; }
        public string clearancesPerGame { get; set; }
        public string matches { get; set; }
        public string pastMatches { get; set; }
        public string cards { get; set; }
        public string goalkeeping { get; set; }
        public string total { get; set; }
        public string gamesPlayed { get; set; }
        public string doubleDoubles { get; set; }
        public string tripleDoubles { get; set; }
        public string extra { get; set; }
        public string attempts { get; set; }
        public string completions { get; set; }
        public string yards { get; set; }
        public string netYards { get; set; }
        public string longest { get; set; }
        public string overallMade { get; set; }
        public string overallBlocked { get; set; }
        public string returns { get; set; }
        public string powerplayPoints { get; set; }
        public string shotPercentage { get; set; }
        public string gameWinningGoals { get; set; }
        public string overtimeGoals { get; set; }
        public string shorthandedPoints { get; set; }
        public string shifts { get; set; }
        public string gamesStarted { get; set; }
        public string shutouts { get; set; }
        public string shortHandedShots { get; set; }
        public string evenShots { get; set; }
        public string powerplayShots { get; set; }
        public string wins { get; set; }
        public string scoring { get; set; }
        public string hockeystatpenalty { get; set; }
        public string time { get; set; }
        public string ballsFaced { get; set; }
        public string battingAvg { get; set; }
        public string battingStrikeRate { get; set; }
        public string caught { get; set; }
        public string fifties { get; set; }
        public string fours { get; set; }
        public string highScore { get; set; }
        public string hundreds { get; set; }
        public string nineties { get; set; }
        public string innings { get; set; }
        public string notOuts { get; set; }
        public string cricketovnum { get; set; }
        public string cricketnoruns { get; set; }
        public string cricketruns { get; set; }
        public string cricketxyruns { get; set; }
        public string cricket_wickets { get; set; }
        public string sixes { get; set; }
        public string stumped { get; set; }
        public string balls { get; set; }
        public string cricket_maidens { get; set; }
        public string cricket_no_ball { get; set; }
        public string cricket_wide_ball { get; set; }
        public string cricket_strike_rate { get; set; }
        public string cricket_fours_info { get; set; }
        public string cricket_sixes_info { get; set; }
        public string bbi { get; set; }
        public string bbm { get; set; }
        public string batting { get; set; }
        public string bowling { get; set; }
        public string highestScore { get; set; }
        public string highestHint { get; set; }
        public string fiveWicketsHaul { get; set; }
        public string bowlingFigures { get; set; }
        public string bowlingAverage { get; set; }
        public string bowlingStrikeRate { get; set; }
        public string conceded { get; set; }
        public string economyRate { get; set; }
        public string fiveWickets { get; set; }
        public string fourWickets { get; set; }
        public string inningsBowled { get; set; }
        public string tenWickets { get; set; }
        public string wickets { get; set; }
        public string fullTime { get; set; }
        public string doubleChance { get; set; }
        public string NHalf { get; set; }
        public string _1stHalf { get; set; }
        public string _2ndHalf { get; set; }
        public string drawNoBet { get; set; }
        public string bothTeamsToScore { get; set; }
        public string firstTeamToScore { get; set; }
        public string handicap { get; set; }
        public string matchGoals { get; set; }
        public string firstSetWinner { get; set; }
        public string totalGamesWon { get; set; }
        public string tieBreakInMatch { get; set; }
        public string nextGameWinner { get; set; }
        public string nextGoal { get; set; }
        public string currentSetWinner { get; set; }
        public string pointSpread { get; set; }
        public string yes { get; set; }
        public string no { get; set; }
        public string helpusimprove { get; set; }
        public string shortsurvey { get; set; }
        public string askmelater { get; set; }
        public string over { get; set; }
        public string under { get; set; }
        public string noGoal { get; set; }
        public string winner { get; set; }
        public string quarterfinals { get; set; }
        public string semifinals { get; set; }
        public string final { get; set; }
        public string season { get; set; }
        public string matchesroundN { get; set; }
        public string qualificationRoundN { get; set; }
        public string round_of_16 { get; set; }
        public string round_of_32 { get; set; }
        public string round_of_64 { get; set; }
        public string round_of_128 { get; set; }
        public string groupN { get; set; }
        public string tennis_break_pts_saved { get; set; }
        public string tennis_service_games_played { get; set; }
        public string tennis_service_games_won { get; set; }
        public string tennis_first_serve_return_pts { get; set; }
        public string tennis_second_serve_return_pts { get; set; }
        public string tennis_break_points_converted { get; set; }
        public string tennis_return_games_played { get; set; }
        public string tennis_total_won { get; set; }
        public string tennis_max_games_in_a_row { get; set; }
        public string tennis_tiebreaks { get; set; }
        public string tennis_service_stat { get; set; }
        public string tennis_points_stat { get; set; }
        public string tennis_games_stat { get; set; }
        public string tennis_winners_stat { get; set; }
        public string tennis_forehand_stat { get; set; }
        public string tennis_backhand_stat { get; set; }
        public string tennis_volley_stat { get; set; }
        public string tennis_groundstroke_stat { get; set; }
        public string tennis_lob_stat { get; set; }
        public string tennis_overhead_stat { get; set; }
        public string tennis_overhead_stroke_stat { get; set; }
        public string tennis_drop_shot_stat { get; set; }
        public string tennis_return_stat { get; set; }
        public string tennis_errors_stat { get; set; }
        public string tennis_unforced_errors_stat { get; set; }
        public string tennis_miscellaneous_stat { get; set; }
        public string Qualification { get; set; }
        public string Knockoutstage { get; set; }
        public string matchfor3rdplace { get; set; }
        public string _3rdPlace { get; set; }
        public string ordinalSet { get; set; }
        public string ordinalQuarter { get; set; }
        public string ordinalInning { get; set; }
        public string ordinalHalf { get; set; }
        public string ordinalPeriod { get; set; }
        public string ordinalExtra { get; set; }
        public string match { get; set; }
        public string goldenSet { get; set; }
        public string overtime { get; set; }
        public string game { get; set; }
        public string started { get; set; }
        public string pause { get; set; }
        public string awaitingExtraTime { get; set; }
        public string awaitingExtraTimeshort { get; set; }
        public string extraTimeHalftime { get; set; }
        public string awaitingPenalties { get; set; }
        public string awaitingPenaltiesshort { get; set; }
        public string extraTimeHalftimeshort { get; set; }
        public string shootout { get; set; }
        public string postponed { get; set; }
        public string startDelayed { get; set; }
        public string canceled { get; set; }
        public string interrupted { get; set; }
        public string suspended { get; set; }
        public string abandoned { get; set; }
        public string walkover { get; set; }
        public string retired { get; set; }
        public string defaulted { get; set; }
        public string ended { get; set; }
        public string aet { get; set; }
        public string afterExtraTime { get; set; }
        public string ap { get; set; }
        public string afterPenalties { get; set; }
        public string ags { get; set; }
        public string afterGoldenSet { get; set; }
        public string _break { get; set; }
        public string extraTime { get; set; }
        public string delayed { get; set; }
        public string halftimeshort { get; set; }
        public string fulltimeshort { get; set; }
        public string notStarted { get; set; }
        public string endOfDayN { get; set; }
        public string willContinue { get; set; }
        public string innBreak { get; set; }
        public string dinner { get; set; }
        public string lunch { get; set; }
        public string teaBreak { get; set; }
        public string fixtureClash { get; set; }
        public string fog { get; set; }
        public string snow { get; set; }
        public string waterloggedPitch { get; set; }
        public string frozenPitch { get; set; }
        public string weatherProblem { get; set; }
        public string floodLight { get; set; }
        public string insufficientPlayers { get; set; }
        public string crowdTrouble { get; set; }
        public string awaitingOfficialsDecision { get; set; }
        public string drinksBreak { get; set; }
        public string fire { get; set; }
        public string floodlightFailure { get; set; }
        public string objectThrownOnPitch { get; set; }
        public string refereeInjury { get; set; }
        public string spectatorOnPitch { get; set; }
        public string all { get; set; }
        public string ordinalPeriodshort { get; set; }
        public string etN { get; set; }
        public string qN { get; set; }
        public string overtimeshort { get; set; }
        public string numberOfPitchesThrown { get; set; }
        public string hitBatsmen { get; set; }
        public string hitByPitch { get; set; }
        public string ordinalGame { get; set; }
        public string streakwins { get; set; }
        public string losses { get; set; }
        public string draws { get; set; }
        public string noLosses { get; set; }
        public string noWins { get; set; }
        public string noGoalsConceded { get; set; }
        public string noGoalsScored { get; set; }
        public string withoutCleanSheet { get; set; }
        public string moreThanGoals { get; set; }
        public string lessThanGoals { get; set; }
        public string moreThanCards { get; set; }
        public string lessThanCards { get; set; }
        public string moreThanCorners { get; set; }
        public string lessThanCorners { get; set; }
        public string bothTeamsScoring { get; set; }
        public string firstToScore { get; set; }
        public string firstToConcede { get; set; }
        public string firstHalfWinner { get; set; }
        public string firstHalfLoser { get; set; }
        public string firstQuarterWinner { get; set; }
        public string firstQuarterLoser { get; set; }
        public string scoredPointsAvg { get; set; }
        public string gamePointsAvg { get; set; }
        public string firstPeriodWinner { get; set; }
        public string firstPeriodLoser { get; set; }
        public string firstPeriodBothScoring { get; set; }
        public string moreThanGoalsInFirst { get; set; }
        public string firstSetLoser { get; set; }
        public string winsSurface { get; set; }
        public string lossesSurface { get; set; }
        public string setsWon { get; set; }
        public string rugbyonePointGoal { get; set; }
        public string rugbytwoPointGoal { get; set; }
        public string rugbythreePointGoal { get; set; }
        public string rugbytry { get; set; }
        public string rugbypenaltyTry { get; set; }
        public string basketballonePoint { get; set; }
        public string basketballtwoPoints { get; set; }
        public string basketballthreePoints { get; set; }
        public string touchdown { get; set; }
        public string amfextraPoint { get; set; }
        public string amftwoPointConversion { get; set; }
        public string amfdefensive2ptConversion { get; set; }
        public string amffieldGoal { get; set; }
        public string amfsafety { get; set; }
        public string amfrouge { get; set; }
        public string am_football_win_probability { get; set; }
        public string am_football_view_incidents { get; set; }
        public string am_football_win_probability_info_title { get; set; }
        public string am_football_win_probability_description { get; set; }
        public string am_football_team_scoring_incidents { get; set; }
        public string am_football_win_probability_incident_icons { get; set; }
        public string am_football_win_probability_td_xp { get; set; }
        public string am_football_win_probability_td_2pt { get; set; }
        public string am_football_win_probability_field_goal { get; set; }
        public string am_football_win_probability_rouge { get; set; }
        public string am_football_scoring_graph_info { get; set; }
        public string score_graph { get; set; }
        public string goal { get; set; }
        public string ownGoal { get; set; }
        public string shotOnTarget { get; set; }
        public string substitution { get; set; }
        public string substitutionIn { get; set; }
        public string substitutionOut { get; set; }
        public string penalty { get; set; }
        public string injury { get; set; }
        public string missedPenalty { get; set; }
        public string penaltyTaker { get; set; }
        public string yellowCard { get; set; }
        public string _2ndYellowCard { get; set; }
        public string redCard { get; set; }
        public string goalAwarded { get; set; }
        public string goalAwardedtrue { get; set; }
        public string goalAwardedfalse { get; set; }
        public string goalNotAwarded { get; set; }
        public string goalNotAwardedtrue { get; set; }
        public string goalNotAwardedfalse { get; set; }
        public string penaltyAwarded { get; set; }
        public string penaltyAwardedtrue { get; set; }
        public string penaltyAwardedfalse { get; set; }
        public string penaltyNotAwarded { get; set; }
        public string penaltyNotAwardedtrue { get; set; }
        public string penaltyNotAwardedfalse { get; set; }
        public string redCardGiven { get; set; }
        public string redCardGiventrue { get; set; }
        public string redCardGivenfalse { get; set; }
        public string cardUpgrade { get; set; }
        public string cardUpgradechanged { get; set; }
        public string cardUpgradenoChange { get; set; }
        public string mistakenIdentity { get; set; }
        public string mistakenIdentitytrue { get; set; }
        public string varDecisionnoChange { get; set; }
        public string varDecision { get; set; }
        public string reviewed { get; set; }
        public string argument { get; set; }
        public string dangerousPlay { get; set; }
        public string simulation { get; set; }
        public string otherReason { get; set; }
        public string unallowedFieldEntering { get; set; }
        public string fight { get; set; }
        public string foul { get; set; }
        public string handball { get; set; }
        public string leavingField { get; set; }
        public string onBench { get; set; }
        public string offTheBallFoul { get; set; }
        public string persistentFouling { get; set; }
        public string professionalFoul { get; set; }
        public string professionalHandball { get; set; }
        public string professionalFoulLastMan { get; set; }
        public string rescindedCard { get; set; }
        public string unsportingBehaviour { get; set; }
        public string timeWasting { get; set; }
        public string violentConduct { get; set; }
        public string postMatch { get; set; }
        public string offTarget { get; set; }
        public string woodwork { get; set; }
        public string goalkeeperSave { get; set; }
        public string divisionLevel { get; set; }
        public string tier { get; set; }
        public string numberOfRounds { get; set; }
        public string averageGoals { get; set; }
        public string homeTeamWins { get; set; }
        public string awayTeamWins { get; set; }
        public string totalPrizeMoney { get; set; }
        public string hostCountries { get; set; }
        public string hostCity { get; set; }
        public string country { get; set; }
        public string countries { get; set; }
        public string cities { get; set; }
        public string surface { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string continent { get; set; }
        public string numberOfSets { get; set; }
        public string groundType { get; set; }
        public string prizeCurrency { get; set; }
        public string prizeMoney { get; set; }
        public string numberOfCompetitors { get; set; }
        public string competitors { get; set; }
        public string sets { get; set; }
        public string dayN { get; set; }
        public string freePracticeN { get; set; }
        public string practiceN { get; set; }
        public string qualificationN { get; set; }
        public string raceN { get; set; }
        public string race { get; set; }
        public string results_title { get; set; }
        public string carpetIndoor { get; set; }
        public string clay { get; set; }
        public string grass { get; set; }
        public string hard { get; set; }
        public string hardcourtIndoor { get; set; }
        public string hardcourtOutdoor { get; set; }
        public string syntheticIndoor { get; set; }
        public string syntheticOutdoor { get; set; }
        public string czechrepublic { get; set; }
        public string iran { get; set; }
        public string hopmancup { get; set; }
        public string trinidadandtobago { get; set; }
        public string colombia { get; set; }
        public string electronicleagues { get; set; }
        public string lesotho { get; set; }
        public string sudan { get; set; }
        public string belarus { get; set; }
        public string southafrica { get; set; }
        public string veteranswomen { get; set; }
        public string palestine { get; set; }
        public string caribbean { get; set; }
        public string drcongo { get; set; }
        public string uae { get; set; }
        public string mali { get; set; }
        public string senegal { get; set; }
        public string equatorialguinea { get; set; }
        public string wheelchairs { get; set; }
        public string bahrain { get; set; }
        public string estonia { get; set; }
        public string serbia { get; set; }
        public string newzealand { get; set; }
        public string usa { get; set; }
        public string libya { get; set; }
        public string panama { get; set; }
        public string curlingmen { get; set; }
        public string canada { get; set; }
        public string andorra { get; set; }
        public string woman { get; set; }
        public string honduras { get; set; }
        public string mongolia { get; set; }
        public string burundi { get; set; }
        public string haiti { get; set; }
        public string world { get; set; }
        public string syria { get; set; }
        public string saotomeandprincipe { get; set; }
        public string hongkong { get; set; }
        public string nepal { get; set; }
        public string bulgaria { get; set; }
        public string croatia { get; set; }
        public string sierraleone { get; set; }
        public string unitedkingdom { get; set; }
        public string burkinafaso { get; set; }
        public string germany { get; set; }
        public string lebanon { get; set; }
        public string macao { get; set; }
        public string guineabissau { get; set; }
        public string asian { get; set; }
        public string veteransmen { get; set; }
        public string tajikistan { get; set; }
        public string uganda { get; set; }
        public string solomonislands { get; set; }
        public string turkey { get; set; }
        public string turkiye { get; set; }
        public string gambia { get; set; }
        public string asiangames { get; set; }
        public string saintkittsandnevis { get; set; }
        public string guatemala { get; set; }
        public string rugbyuniontens { get; set; }
        public string gibraltar { get; set; }
        public string daviscup { get; set; }
        public string uruguay { get; set; }
        public string taiwan { get; set; }
        public string oman { get; set; }
        public string cameroon { get; set; }
        public string denmark { get; set; }
        public string moldova { get; set; }
        public string laos { get; set; }
        public string mozambique { get; set; }
        public string afghanistan { get; set; }
        public string europe { get; set; }
        public string motocross { get; set; }
        public string kazakhstan { get; set; }
        public string nicaragua { get; set; }
        public string biathlonmixed { get; set; }
        public string saudiarabia { get; set; }
        public string bobsleighwomen { get; set; }
        public string southkorea { get; set; }
        public string _500mwomen { get; set; }
        public string portugal { get; set; }
        public string romania { get; set; }
        public string liberia { get; set; }
        public string rally { get; set; }
        public string lithuania { get; set; }
        public string crosscountrymen { get; set; }
        public string benin { get; set; }
        public string ukraine { get; set; }
        public string tahiti { get; set; }
        public string newcaledonia { get; set; }
        public string cyprus { get; set; }
        public string zanzibar { get; set; }
        public string champcarworldseries { get; set; }
        public string northcentralamerica { get; set; }
        public string scotland { get; set; }
        public string indonesia { get; set; }
        public string mauritania { get; set; }
        public string aruba { get; set; }
        public string bikes { get; set; }
        public string djibouti { get; set; }
        public string jordan { get; set; }
        public string montenegro { get; set; }
        public string dominicanrepublic { get; set; }
        public string puertorico { get; set; }
        public string namibia { get; set; }
        public string cambodia { get; set; }
        public string malawi { get; set; }
        public string singapore { get; set; }
        public string albania { get; set; }
        public string bahamas { get; set; }
        public string skijumping { get; set; }
        public string biathlonwomen { get; set; }
        public string angola { get; set; }
        public string bermuda { get; set; }
        public string crosscountrywomen { get; set; }
        public string snowboardmen { get; set; }
        public string zambia { get; set; }
        public string philippines { get; set; }
        public string africa { get; set; }
        public string indycar { get; set; }
        public string formula1 { get; set; }
        public string finland { get; set; }
        public string chile { get; set; }
        public string exhibition { get; set; }
        public string ireland { get; set; }
        public string macedonia { get; set; }
        public string challengerwomen { get; set; }
        public string morocco { get; set; }
        public string maldives { get; set; }
        public string alpinemixed { get; set; }
        public string unitedarabemirates { get; set; }
        public string czech { get; set; }
        public string northerncyprus { get; set; }
        public string wales { get; set; }
        public string azerbaijan { get; set; }
        public string northamerica { get; set; }
        public string papuanewguinea { get; set; }
        public string guam { get; set; }
        public string southsudan { get; set; }
        public string swaziland { get; set; }
        public string national { get; set; }
        public string porschesupercup { get; set; }
        public string tanzania { get; set; }
        public string myanmar { get; set; }
        public string thailand { get; set; }
        public string georgia { get; set; }
        public string paraguay { get; set; }
        public string sanmarino { get; set; }
        public string brazil { get; set; }
        public string barbados { get; set; }
        public string kyrgyzstan { get; set; }
        public string curacao { get; set; }
        public string federationcup { get; set; }
        public string supercars { get; set; }
        public string faroeislands { get; set; }
        public string guyana { get; set; }
        public string niger { get; set; }
        public string mauritius { get; set; }
        public string slovakia { get; set; }
        public string ghana { get; set; }
        public string curlingwomen { get; set; }
        public string rwanda { get; set; }
        public string brunei { get; set; }
        public string greenland { get; set; }
        public string mayotte { get; set; }
        public string reunion { get; set; }
        public string itfmen { get; set; }
        public string gabon { get; set; }
        public string olympics { get; set; }
        public string england { get; set; }
        public string norway { get; set; }
        public string seychelles { get; set; }
        public string caymanislands { get; set; }
        public string peru { get; set; }
        public string ivorycoast { get; set; }
        public string vanuatu { get; set; }
        public string legends { get; set; }
        public string antiguaandbarbuda { get; set; }
        public string races { get; set; }
        public string congorepublic { get; set; }
        public string juniors { get; set; }
        public string asia { get; set; }
        public string qatar { get; set; }
        public string internationalyouth { get; set; }
        public string specials { get; set; }
        public string italy { get; set; }
        public string men { get; set; }
        public string australia { get; set; }
        public string nigeria { get; set; }
        public string somalia { get; set; }
        public string slovenia { get; set; }
        public string srilanka { get; set; }
        public string northkorea { get; set; }
        public string kenya { get; set; }
        public string elsalvador { get; set; }
        public string worldbaseballclassic { get; set; }
        public string northernireland { get; set; }
        public string rugbyunionsevens { get; set; }
        public string russia { get; set; }
        public string pakistan { get; set; }
        public string belgium { get; set; }
        public string skijumpingwomen { get; set; }
        public string france { get; set; }
        public string syrianarabrepublic { get; set; }
        public string alpinewomen { get; set; }
        public string netherlands { get; set; }
        public string southamerica { get; set; }
        public string international { get; set; }
        public string internationalclubs { get; set; }
        public string rugbyunion { get; set; }
        public string friendlygames { get; set; }
        public string tunisia { get; set; }
        public string uzbekistan { get; set; }
        public string iceland { get; set; }
        public string samoa { get; set; }
        public string kuwait { get; set; }
        public string liechtenstein { get; set; }
        public string oceania { get; set; }
        public string austria { get; set; }
        public string chad { get; set; }
        public string alandislands { get; set; }
        public string americansamoa { get; set; }
        public string anguilla { get; set; }
        public string antarctica { get; set; }
        public string bonairesinteustatiusandsaba { get; set; }
        public string bouvetisland { get; set; }
        public string britishindianoceanterritory { get; set; }
        public string britishvirginislands { get; set; }
        public string burma { get; set; }
        public string christmasisland { get; set; }
        public string cocoskeelingislands { get; set; }
        public string cookislands { get; set; }
        public string dominica { get; set; }
        public string falklandislandsmalvinas { get; set; }
        public string frenchguyana { get; set; }
        public string frenchsouthernterritories { get; set; }
        public string grenada { get; set; }
        public string guadeloupe { get; set; }
        public string guernsey { get; set; }
        public string heardislandandmcdonaldislands { get; set; }
        public string holyseevaticancitystate { get; set; }
        public string isleofman { get; set; }
        public string jersey { get; set; }
        public string kiribati { get; set; }
        public string marshallislands { get; set; }
        public string martinique { get; set; }
        public string micronesiafederatedstatesof { get; set; }
        public string montserrat { get; set; }
        public string nauru { get; set; }
        public string netherlandsantilles { get; set; }
        public string niue { get; set; }
        public string norfolkisland { get; set; }
        public string northernmarianaislands { get; set; }
        public string palau { get; set; }
        public string pitcairn { get; set; }
        public string saintbarthelemy { get; set; }
        public string sainthelenaascensionandtristandacunha { get; set; }
        public string saintlucia { get; set; }
        public string saintmartinfrenchpart { get; set; }
        public string saintpierreandmiquelon { get; set; }
        public string saintvincentandthegrenadines { get; set; }
        public string southgeorgiaandthesouthsandwichislands { get; set; }
        public string stkittsandnevis { get; set; }
        public string surinam { get; set; }
        public string svalbardandjanmayen { get; set; }
        public string tokelau { get; set; }
        public string tonga { get; set; }
        public string turksandcaicosislands { get; set; }
        public string tuvalu { get; set; }
        public string usaminoroutlyingislands { get; set; }
        public string virginislandsus { get; set; }
        public string wallisandfutuna { get; set; }
        public string westernsahara { get; set; }
        public string madagascar { get; set; }
        public string kosovo { get; set; }
        public string comoros { get; set; }
        public string guinea { get; set; }
        public string formulae { get; set; }
        public string olympicgames { get; set; }
        public string ecuador { get; set; }
        public string israel { get; set; }
        public string spain { get; set; }
        public string turkmenistan { get; set; }
        public string india { get; set; }
        public string biathlonmen { get; set; }
        public string speedway { get; set; }
        public string iraq { get; set; }
        public string chinesetaipei { get; set; }
        public string luxembourg { get; set; }
        public string mexico { get; set; }
        public string algeria { get; set; }
        public string latvia { get; set; }
        public string rugbyleague { get; set; }
        public string botswana { get; set; }
        public string bolivia { get; set; }
        public string crimea { get; set; }
        public string yemen { get; set; }
        public string venezuela { get; set; }
        public string zimbabwe { get; set; }
        public string nordiccombined { get; set; }
        public string itfwomen { get; set; }
        public string cuba { get; set; }
        public string argentina { get; set; }
        public string bosniaherzegovina { get; set; }
        public string bosniaandherzegovina { get; set; }
        public string suriname { get; set; }
        public string jamaica { get; set; }
        public string alpinemen { get; set; }
        public string sweden { get; set; }
        public string togo { get; set; }
        public string ethiopia { get; set; }
        public string gp2series { get; set; }
        public string fiji { get; set; }
        public string japan { get; set; }
        public string belize { get; set; }
        public string egypt { get; set; }
        public string hungary { get; set; }
        public string switzerland { get; set; }
        public string bangladesh { get; set; }
        public string vietnam { get; set; }
        public string malta { get; set; }
        public string armenia { get; set; }
        public string skijumpingmixed { get; set; }
        public string poland { get; set; }
        public string china { get; set; }
        public string lugemixed { get; set; }
        public string costarica { get; set; }
        public string snowboardwomen { get; set; }
        public string malaysia { get; set; }
        public string rallycross { get; set; }
        public string greece { get; set; }
        public string simulatedrealityleague { get; set; }
        public string simulatedrealitywomen { get; set; }
        public string northmacedonia { get; set; }
        public string bhutan { get; set; }
        public string timorleste { get; set; }
        public string capeverde { get; set; }
        public string centralafricanrep { get; set; }
        public string congo { get; set; }
        public string dominicanrep { get; set; }
        public string eritrea { get; set; }
        public string greatbritain { get; set; }
        public string monaco { get; set; }
        public string westgermany { get; set; }
        public string dota2 { get; set; }
        //public string dota2 { get; set; }
        public string csgo { get; set; }
        public string lol { get; set; }
        public string amateurCategory { get; set; }
        public string descriptionmain { get; set; }
        public string descriptionmainamericanfootball { get; set; }
        public string descriptionmainaussierules { get; set; }
        public string descriptionmainbadminton { get; set; }
        public string descriptionmaincricket { get; set; }
        public string descriptionmaindarts { get; set; }
        public string descriptionmainfutsal { get; set; }
        public string descriptionmainrugby { get; set; }
        public string descriptionmainsnooker { get; set; }
        public string descriptionmainwaterpolo { get; set; }
        public string descriptionmainmotorsport { get; set; }
        public string descriptionmainmotorsportstage { get; set; }
        public string descriptionfavorites { get; set; }
        public string descriptionstandings { get; set; }
        public string descriptionstandingsdetailed { get; set; }
        public string descriptionsearch { get; set; }
        public string descriptionrankingsatp { get; set; }
        public string descriptionrankingswta { get; set; }
        public string descriptionplayer { get; set; }
        public string descriptionbetting { get; set; }
        public string descriptionevent { get; set; }
        public string descriptioneventv2 { get; set; }
        public string descriptioneventesports { get; set; }
        public string descriptionuteuro { get; set; }
        public string descriptionutworldCup { get; set; }
        public string descriptiondriver { get; set; }
        public string keywordsmain { get; set; }
        public string keywordssport { get; set; }
        public string keywordsmotorsport { get; set; }
        public string keywordsstandings { get; set; }
        public string keywordssearch { get; set; }
        public string keywordsplayer { get; set; }
        public string keywordsbetting { get; set; }
        public string keywordsmanager { get; set; }
        public string keywordsdriver { get; set; }
        public string headerTitlemain { get; set; }
        public string headerTitlefavorites { get; set; }
        public string headerTitleitem { get; set; }
        public string headerTitlestandings { get; set; }
        public string headerTitlerankings { get; set; }
        public string headerTitlemotorsport { get; set; }
        public string headerTitlecycling { get; set; }
        public string headerTitleplayer { get; set; }
        public string headerTitlereferee { get; set; }
        public string headerTitleevent { get; set; }
        public string headerTitleeventv3 { get; set; }
        public string headerTitleeventtennis { get; set; }
        public string headerTitleuteuro { get; set; }
        public string headerTitleutworldCup { get; set; }
        public string headerTitledriver { get; set; }
        public string headerTitlechallenger { get; set; }
        public string headerTitledavis { get; set; }
        public string headerTitletennisv1 { get; set; }
        public string headerTitletennisv2 { get; set; }
        public string headerTitlettbundesliga { get; set; }
        public string headerTitlettcl { get; set; }
        public string headerTitlettec { get; set; }
        public string headerTitlettettu { get; set; }
        public string headerTitlettolywcships { get; set; }
        public string headerTitlettwc { get; set; }
        public string headerTitlettjuniorwc { get; set; }
        public string headerTitlettsetkattuwc { get; set; }
        public string footerabout { get; set; }
        public string footeradvertise { get; set; }
        public string footertopEvents { get; set; }
        public string footerunder18 { get; set; }
        public string footervisitOnSocialNetwork { get; set; }
        public string footerrightsReserved { get; set; }
        public string footerprivacyPolicy { get; set; }
        public string footercontact { get; set; }
        public string teamabout { get; set; }
        public string tournamentaboutfootballleague1 { get; set; }
        public string tournamentaboutfootballleague2 { get; set; }
        public string tournamentaboutfootballleague3 { get; set; }
        public string tournamentaboutfootballleague4 { get; set; }
        public string tournamentaboutfootballleague5 { get; set; }
        public string tournamentaboutfootballleague6 { get; set; }
        public string tournamentaboutfootballtitle2 { get; set; }
        public string tournamentaboutfootballleague7 { get; set; }
        public string tournamentaboutfootballleague8 { get; set; }
        public string tournamentaboutfootballleague9 { get; set; }
        public string tournamentaboutfootballleague10 { get; set; }
        public string tournamentaboutfootballleague11 { get; set; }
        public string tournamentaboutfootballleague12 { get; set; }
        public string tournamentaboutfootballleague13 { get; set; }
        public string tournamentaboutfootballleague14 { get; set; }
        public string tournamentaboutfootballleague15 { get; set; }
        public string tournamentaboutfootballtitle3 { get; set; }
        public string tournamentaboutfootballleague16 { get; set; }
        public string tournamentaboutfootballleague17 { get; set; }
        public string tournamentaboutfootballtitle4 { get; set; }
        public string tournamentaboutfootballleague18 { get; set; }
        public string tournamentaboutfootballleague19 { get; set; }
        public string tournamentaboutfootballleague20 { get; set; }
        public string tournamentaboutfootballleague21 { get; set; }
        public string tournamentaboutfootballleague22 { get; set; }
        public string tournamentaboutfootballtitle5 { get; set; }
        public string tournamentaboutfootballleague23 { get; set; }
        public string tournamentaboutfootballleague24 { get; set; }
        public string tournamentaboutfootballtitle6 { get; set; }
        
        [JsonPropertyName("tournament.about.football.league25")]
        public string tournamentaboutfootballleague25 { get; set; }
        [JsonPropertyName("tournament.about.football.league26")]
        public string tournamentaboutfootballleague26 { get; set; }
        [JsonPropertyName("tournament.about.football.league27")]
        public string tournamentaboutfootballleague27 { get; set; }
        [JsonPropertyName("tournament.about.football.league28")]
        public string tournamentaboutfootballleague28 { get; set; }
        [JsonPropertyName("tournament.about.football.league29")]
        public string tournamentaboutfootballleague29 { get; set; }
        [JsonPropertyName("tournament.about.football.league30")]
        public string tournamentaboutfootballleague30 { get; set; }
        [JsonPropertyName("tournament.about.football.league31")]
        public string tournamentaboutfootballleague31 { get; set; }
        [JsonPropertyName("tournament.about.football.league32")]
        public string tournamentaboutfootballleague32 { get; set; }
        [JsonPropertyName("tournament.about.football.league33")]
        public string tournamentaboutfootballleague33 { get; set; }
        [JsonPropertyName("tournament.about.football.league34")]
        public string tournamentaboutfootballleague34 { get; set; }
        [JsonPropertyName("tournament.about.football.league35")]
        public string tournamentaboutfootballleague35 { get; set; }
        public string tournamentaboutfootballleague36 { get; set; }
        public string tournamentaboutfootballleague37 { get; set; }
        public string tournamentaboutfootballleague38 { get; set; }
        public string tournamentaboutfootballleague39 { get; set; }
        public string tournamentaboutfootballleague40 { get; set; }
        public string tournamentaboutfootballleague42 { get; set; }
        public string tournamentaboutfootballleague43 { get; set; }
        public string tournamentaboutfootballleague44 { get; set; }
        public string tournamentaboutfootballleague45 { get; set; }
        public string tournamentaboutfootballcup1 { get; set; }
        public string tournamentaboutfootballtitle7 { get; set; }
        public string tournamentaboutfootballcup2 { get; set; }
        public string tournamentaboutfootballcup3 { get; set; }
        public string tournamentaboutfootballcup4 { get; set; }
        public string tournamentaboutfootballcup5 { get; set; }
        public string tournamentaboutfootballcup6 { get; set; }
        public string tournamentaboutfootballcup7 { get; set; }
        public string tournamentaboutfootballcup8 { get; set; }
        public string tournamentaboutfootballcup9 { get; set; }
        public string tournamentaboutfootballcup10 { get; set; }
        public string tournamentaboutfootballcup11 { get; set; }
        public string tournamentaboutfootballfriendly1 { get; set; }
        public string tournamentaboutfootballfriendly2 { get; set; }
        public string tournamentaboutfootballfriendly3 { get; set; }
        public string tournamentaboutfootballfriendly4 { get; set; }
        public string tournamentaboutfootballfriendly5 { get; set; }
        public string tournamentaboutfootballfriendly6 { get; set; }
        public string tournamentaboutfootballfriendly7 { get; set; }
        public string tournamentaboutfootballfriendly8 { get; set; }
        public string tournamentaboutfootballfriendly9 { get; set; }
        public string tournamentaboutfootballqualifyingCup1 { get; set; }
        public string tournamentaboutfootballqualifyingCup2 { get; set; }
        public string tournamentaboutfootballqualifyingCup3 { get; set; }
        public string tournamentaboutfootballqualifyingCup4 { get; set; }
        public string tournamentaboutfootballqualifyingCup5 { get; set; }
        public string tournamentaboutfootballqualifyingTournament1 { get; set; }
        public string tournamentaboutfootballqualifyingTournament2 { get; set; }
        public string tournamentaboutfootballqualifyingTournament3 { get; set; }
        public string tournamentaboutfootballqualifyingTournament4 { get; set; }
        public string tournamentaboutfootballqualifyingTournament5 { get; set; }
        public string tournamentaboutfootballqualifyingTournament6 { get; set; }
        public string tournamentaboutfootballqualifyingTournament7 { get; set; }
        public string tournamentaboutfootballqualifyingTournament8 { get; set; }
        public string tournamentaboutfootballqualifyingTournament9 { get; set; }
        public string tournamentaboutfootballqualifyingTournament10 { get; set; }
        public string tournamentaboutfootballqualifyingTournament11 { get; set; }
        public string tournamentaboutfootballqualifyingTournament12 { get; set; }
        public string tournamentaboutfootballqualifyingTournament13 { get; set; }
        public string tournamentaboutfootballqualifyingTournament14 { get; set; }
        public string tournamentaboutfootballqualifyingTournament15 { get; set; }
        public string tournamentaboutfootballqualifyingTournament16 { get; set; }
        public string tournamentaboutfootballqualifyingTournament17 { get; set; }
        public string tournamentaboutfootballqualifyingTournament18 { get; set; }
        public string tournamentaboutfootballqualifyingTournament19 { get; set; }
        public string tournamentaboutfootballqualifyingTournament20 { get; set; }
        public string tournamentaboutfootballqualifyingTournament21 { get; set; }
        public string tournamentaboutfootballqualifyingTournament22 { get; set; }
        public string tournamentaboutfootballqualifyingTournament23 { get; set; }
        public string tournamentaboutfootballqualifyingTournament24 { get; set; }
        public string tournamentaboutfootballqualifyingTournament25 { get; set; }
        public string tournamentaboutfootballqualifyingTournament26 { get; set; }
        public string tournamentaboutfootballqualifyingTournament27 { get; set; }
        public string tournamentaboutfootballqualifyingTournament28 { get; set; }
        public string tournamentaboutfootballsuperCup1 { get; set; }
        public string tournamentaboutfootballsuperCup2 { get; set; }
        public string tournamentaboutfootballtitle8 { get; set; }
        public string tournamentaboutfootballsuperCup3 { get; set; }
        public string tournamentaboutfootballsuperCup4 { get; set; }
        public string tournamentaboutfootballsuperCup5 { get; set; }
        public string tournamentaboutfootballsuperCup6 { get; set; }
        public string tournamentaboutfootballsuperCup7 { get; set; }
        public string tournamentaboutfootballsuperCup8 { get; set; }
        public string tournamentaboutfootballsuperCup9 { get; set; }
        public string tournamentaboutfootballtournament1 { get; set; }
        public string tournamentaboutfootballtournament2 { get; set; }
        public string tournamentaboutfootballtournament3 { get; set; }
        public string tournamentaboutfootballtournament4 { get; set; }
        public string tournamentaboutfootballtournament5 { get; set; }
        public string tournamentaboutfootballtournament6 { get; set; }
        public string tournamentaboutfootballtournament7 { get; set; }
        public string tournamentaboutfootballtournament8 { get; set; }
        public string tournamentaboutfootballtournament9 { get; set; }
        public string tournamentaboutfootballtournament10 { get; set; }
        public string tournamentaboutfootballtournament11 { get; set; }
        public string tournamentaboutfootballtournament12 { get; set; }
        public string tournamentaboutfootballtournament13 { get; set; }
        public string tournamentaboutfootballtournament14 { get; set; }
        public string tournamentaboutfootballtournament15 { get; set; }
        public string tournamentaboutfootballtournament16 { get; set; }
        public string tournamentaboutfootballtournament17 { get; set; }
        public string tournamentaboutfootballtournament18 { get; set; }
        public string tournamentabouttennisa1 { get; set; }
        public string tournamentabouttennisa2 { get; set; }
        public string tournamentabouttennisa3 { get; set; }
        public string tournamentabouttennisa4 { get; set; }
        public string tournamentabouttennisa5 { get; set; }
        public string tournamentabouttennisa6 { get; set; }
        public string tournamentabouttennisa7 { get; set; }
        public string tournamentabouttennisa8 { get; set; }
        public string tournamentabouttennisa9 { get; set; }
        public string tournamentabouttennisa10 { get; set; }
        public string tournamentabouttennisa11 { get; set; }
        public string tournamentabouttennisa12 { get; set; }
        public string tournamentabouttennisa13 { get; set; }
        public string tournamentabouttennisa14 { get; set; }
        public string tournamentabouttennisa15 { get; set; }
        public string tournamentabouttennisa16 { get; set; }
        public string tournamentabouttennisa17 { get; set; }
        public string tournamentabouttennisa18 { get; set; }
        public string tournamentabouttennisa19 { get; set; }
        public string tournamentabouttennisa20 { get; set; }
        public string tournamentabouttennisa21 { get; set; }
        public string tournamentabouttennisa22 { get; set; }
        public string tournamentabouttennisa23 { get; set; }
        public string tournamentabouttennisa24 { get; set; }
        public string tournamentabouttennisa25 { get; set; }
        public string tournamentabouttennisa26 { get; set; }
        public string tournamentabouttennisa27 { get; set; }
        public string tournamentabouttennisa28 { get; set; }
        public string tournamentabouttennisa29 { get; set; }
        public string tournamentabouttennisa30 { get; set; }
        public string tournamentabouttennisa31 { get; set; }
        public string tournamentabouttennisa32 { get; set; }
        public string tournamentabouttennisa33 { get; set; }
        public string tournamentabouttennisa34 { get; set; }
        public string tournamentabouttennisa35 { get; set; }
        public string tournamentabouttennisa36 { get; set; }
        public string tournamentabouttennisa37 { get; set; }
        public string tournamentabouttennisa38 { get; set; }
        public string tournamentabouttennisa39 { get; set; }
        public string tournamentabouttennisa40 { get; set; }
        public string tournamentabouttennisa41 { get; set; }
        public string tournamentabouttennisa42 { get; set; }
        public string tournamentabouttennisa43 { get; set; }
        public string tournamentabouttennisa44 { get; set; }
        public string tournamentabouttennisa46 { get; set; }
        public string tournamentabouttennisa47 { get; set; }
        public string tournamentabouttennisa48 { get; set; }
        public string tournamentabouttennisa49 { get; set; }
        public string tournamentabouttennisa50 { get; set; }
        public string tournamentabouttennisa51 { get; set; }
        public string tournamentabouttennisa52 { get; set; }
        public string abouttitleholder { get; set; }
        public string abouttitleholdermosttitles { get; set; }
        public string abouttabletennis1 { get; set; }
        public string abouttabletennis2 { get; set; }
        public string aboutttbl1 { get; set; }
        public string aboutecl1 { get; set; }
        public string aboutecl2 { get; set; }
        public string aboutwcl1 { get; set; }
        public string aboutwcl2 { get; set; }
        public string aboutttec1 { get; set; }
        public string aboutttec2 { get; set; }
        public string aboutttettumen1 { get; set; }
        public string aboutttettumen2 { get; set; }
        public string aboutttettumen3 { get; set; }
        public string aboutttettuwomen1 { get; set; }
        public string aboutttettuwomen2 { get; set; }
        public string aboutttettuwomen3 { get; set; }
        public string aboutttolympics1 { get; set; }
        public string aboutttolympics2 { get; set; }
        public string aboutttwchips1 { get; set; }
        public string aboutttwchips2 { get; set; }
        public string aboutttwc1 { get; set; }
        public string aboutttwcwomen1 { get; set; }
        public string aboutttwcbullet1 { get; set; }
        public string aboutttwcbullet2 { get; set; }
        public string aboutttwcbullet3 { get; set; }
        public string aboutttwcbullet4 { get; set; }
        public string aboutttwcbullet5 { get; set; }
        public string aboutttwcbullet6 { get; set; }
        public string aboutttwc2 { get; set; }
        public string aboutttjuniorwchips1 { get; set; }
        public string aboutttittfchallenge1 { get; set; }
        public string aboutttsetkacup { get; set; }
        public string aboutttgeneric1 { get; set; }
        public string tennisstayuptodate { get; set; }
        public string tournamentabouttennist1 { get; set; }
        public string tournamentabouttennist2 { get; set; }
        public string tournamentabouttennist3 { get; set; }
        public string footertextdefault { get; set; }
        public string footertextamericanfootball { get; set; }
        public string footertextaussierules { get; set; }
        public string footertextbandy { get; set; }
        public string footertextbasketball { get; set; }
        public string footertextbadminton { get; set; }
        public string footertextbaseball { get; set; }
        public string footertextcricket { get; set; }
        public string footertextdarts { get; set; }
        public string footertextfootball { get; set; }
        public string footertextfloorball { get; set; }
        public string footertextfutsal { get; set; }
        public string footertexthandball { get; set; }
        public string footertexticehockey { get; set; }
        public string footertextrugby { get; set; }
        public string footertexttennis { get; set; }
        public string footertexttennisrankingsatp { get; set; }
        public string footertexttennisrankingswta { get; set; }
        public string footertextsnooker { get; set; }
        public string footertextvolleyball { get; set; }
        public string footertextwaterpolo { get; set; }
        public string footertextmotorsport { get; set; }
        public string footertextmotorsportstage { get; set; }
        public string categorytourtournaments { get; set; }
        public string mostsinglestitles { get; set; }
        public string atpaboutp1 { get; set; }
        public string atpaboutp2 { get; set; }
        public string atpaboutp3 { get; set; }
        public string wtaaboutp1 { get; set; }
        public string wtaaboutp2 { get; set; }
        public string wtaaboutp3 { get; set; }
        public string challengeraboutp1 { get; set; }
        public string challengeraboutp2 { get; set; }
        public string itfmenaboutp1 { get; set; }
        public string itfmenaboutp2 { get; set; }
        public string itfwomenaboutp1 { get; set; }
        public string itfwomenaboutp2 { get; set; }
        public string grandslamaboutp1 { get; set; }
        public string grandslamaboutp2 { get; set; }
        public string shot_outcome { get; set; }
        public string shot_situation { get; set; }
        public string shot_type { get; set; }
        public string goal_zone { get; set; }
        public string shot_outcome_miss { get; set; }
        public string shot_outcome_post { get; set; }
        public string shot_outcome_attempt_saved { get; set; }
        public string shot_outcome_block { get; set; }
        public string shot_situation_regular_play { get; set; }
        public string shot_situation_fast_break { get; set; }
        public string shot_situation_set_piece { get; set; }
        public string shot_situation_from_corner { get; set; }
        public string shot_situation_free_kick { get; set; }
        public string shot_situation_assisted { get; set; }
        public string shot_situation_scramble { get; set; }
        public string shot_situation_throw_in { get; set; }
        public string shot_situation_penalty { get; set; }
        public string shot_situation_shootout { get; set; }
        public string goal_zone_high { get; set; }
        public string goal_zone_low_left { get; set; }
        public string goal_zone_high_left { get; set; }
        public string goal_zone_low_centre { get; set; }
        public string goal_zone_high_centre { get; set; }
        public string goal_zone_low_right { get; set; }
        public string goal_zone_high_right { get; set; }
        public string goal_zone_close_left { get; set; }
        public string goal_zone_close_right { get; set; }
        public string goal_zone_close_high { get; set; }
        public string goal_zone_close_left_and_high { get; set; }
        public string goal_zone_close_right_and_high { get; set; }
        public string goal_zone_left { get; set; }
        public string goal_zone_right { get; set; }
        public string type_of_shot_head { get; set; }
        public string type_of_shot_left_footed { get; set; }
        public string type_of_shot_right_footed { get; set; }
        public string type_of_shot_other_body_part { get; set; }
        public string message_match_shotmap { get; set; }
        public string title_match_shotmap { get; set; }
        public string shotmap_penalty_shootout { get; set; }
        public string mma { get; set; }
        public string main_card { get; set; }
        public string prelims { get; set; }
        public string organisations { get; set; }
        public string main_event { get; set; }
        public string co_main_events { get; set; }
        public string featured_event { get; set; }
        public string divisions { get; set; }
        public string division { get; set; }
        public string number_of_fighters { get; set; }
        public string current_president { get; set; }
        public string owner { get; set; }
        public string foundation_date { get; set; }
        public string mens_division { get; set; }
        public string womens_division { get; set; }
        public string last_fight { get; set; }
        public string flyweight { get; set; }
        public string bantamweight { get; set; }
        public string featherweight { get; set; }
        public string lightweight { get; set; }
        public string welterweight { get; set; }
        public string middleweight { get; set; }
        public string light_heavyweight { get; set; }
        public string heavyweight { get; set; }
        public string pound_for_pound { get; set; }
        public string super_heavyweight_cage { get; set; }
        public string openweight_mma { get; set; }
        public string division_title { get; set; }
        public string womens_division_name { get; set; }
        public string pre_match_rankings { get; set; }
        public string fighter { get; set; }
        public string record { get; set; }
        public string fighters_bio { get; set; }
        public string home_country { get; set; }
        public string reach { get; set; }
        public string general { get; set; }
        public string distance { get; set; }
        public string clinch { get; set; }
        public string ground { get; set; }
        public string striking_per_round { get; set; }
        public string significant_strike_avg { get; set; }
        public string mma_landed_all_strikes { get; set; }
        public string strikes_landed_by_zones { get; set; }
        public string head { get; set; }
        public string body { get; set; }
        public string legs { get; set; }
        public string grappling_per_min { get; set; }
        public string choke_landed { get; set; }
        public string choke { get; set; }
        public string arms { get; set; }
        public string position_statistics { get; set; }
        public string avg_time_in_position { get; set; }
        public string control_in_position_overall { get; set; }
        public string defense_efficiency { get; set; }
        public string choke_defended { get; set; }
        public string right_arm { get; set; }
        public string left_arm { get; set; }
        public string right_leg { get; set; }
        public string left_leg { get; set; }
        public string knee { get; set; }
        public string elbow { get; set; }
        public string max_avg_landed_strikes { get; set; }
        public string min_avg_landed_strikes { get; set; }
        public string no_strikes_landed { get; set; }
        public string takedowns_avg { get; set; }
        public string submission_attempts_avg { get; set; }
        public string max_avg_attempted_sub { get; set; }
        public string min_avg_attempted_sub { get; set; }
        public string no_submission_attempts { get; set; }
        public string transitions_succeeded { get; set; }
        public string max_avg_defended_strikes { get; set; }
        public string min_avg_defended_strikes { get; set; }
        public string no_strikes_defended { get; set; }
        public string mma_receive_notifications_organisation { get; set; }
        public string mma_receive_notifications_fighter { get; set; }
        public string mma_receiving_notifications_organisation { get; set; }
        public string mma_receiving_notifications_fighter { get; set; }
        public string win_type_format { get; set; }
        public string win { get; set; }
        public string draw { get; set; }
        public string status_round { get; set; }
        public string success_attempted { get; set; }
        public string significant_strikes { get; set; }
        public string grappling { get; set; }
        public string total_strikes { get; set; }
        public string strikes_by_position { get; set; }
        public string strikes_by_zones { get; set; }
        public string knockdowns { get; set; }
        public string total_attempts { get; set; }
        public string submission_attempts_by_zones { get; set; }
        public string time_in_position { get; set; }
        public string control_in_position { get; set; }
        public string current_division { get; set; }
        public string current_ranking { get; set; }
        public string ranking { get; set; }
        public string biography { get; set; }
        public string reach_mma { get; set; }
        public string style_mma { get; set; }
        public string fighting_out_of { get; set; }
        public string last_divisions { get; set; }
        public string mma_brackets_empty_state { get; set; }
        public string pfl_records { get; set; }
        public string records { get; set; }
        public string knockouts { get; set; }
        public string submissions { get; set; }
        public string striking_per_round_info_text { get; set; }
        public string grappling_per_min_info_text { get; set; }
        public string position_stats_mma_info { get; set; }
        public string significant_strikes_info_text { get; set; }
        public string grappling_info_text { get; set; }
        public string position_statistics_mma_live_info { get; set; }
        public string minutes_left_format_mma { get; set; }
        public string round_mma { get; set; }
        public string current_position_mma { get; set; }
        public string next_fight_mma { get; set; }
        public string ground_mma { get; set; }
        public string undefined_mma { get; set; }
        public string distance_mma { get; set; }
        public string ground_grapple_red_mma { get; set; }
        public string ground_grapple_blue_mma { get; set; }
        public string grapple_red_mma { get; set; }
        public string grapple_blue_mma { get; set; }
        public string in_progress_mma { get; set; }
        public string stoppage_mma { get; set; }
        public string takedowns_mma { get; set; }
        public string right_short { get; set; }
        public string left_short { get; set; }
        public string early_prelims_mma { get; set; }
        public string fight_starts_soon_mma { get; set; }
        public string pre_match_stats_info_mma { get; set; }
        public string fights_mma { get; set; }
        public string no_contest_mma { get; set; }
        public string mma_career_records { get; set; }
        public string fighters_info_mma { get; set; }
        public string date_of_birth { get; set; }
        public string fight_status_mma { get; set; }
        public string mma_awaiting_decision_status { get; set; }
        public string no_events_empty_state_mma { get; set; }
        public string fighter_ranking_mma { get; set; }
        public string catchweight { get; set; }
        public string strawweight { get; set; }
        public string mma_receive_notifications_fight { get; set; }
        public string mma_receiving_notifications_fight { get; set; }
        public string mma_status_round_short { get; set; }
        public string events_title { get; set; }
        public string embed_cta { get; set; }
        public string stage_result_finished { get; set; }
        public string stage_result_accident { get; set; }
        public string stage_result_fuelpump { get; set; }
        public string stage_result_reargear { get; set; }
        public string stage_result_electrical { get; set; }
        public string stage_result_transmission { get; set; }
        public string stage_result_garage { get; set; }
        public string stage_result_clutch { get; set; }
        public string stage_result_brakes { get; set; }
        public string stage_result_engine { get; set; }
        public string stage_result_suspension { get; set; }
        public string stage_result_too_slow { get; set; }
        public string average_positions { get; set; }
        public string average_positions_available_when { get; set; }
        public string low_player_involvement { get; set; }
        public string show_substitutions { get; set; }
        public string season_penalty_shotmap { get; set; }
        public string empty_season_penalty_shotmap { get; set; }
        public string mma_submissions_average { get; set; }
        public string no_contest_mma_short { get; set; }
        public string mma_fighting_style_striker { get; set; }
        public string mma_fighting_style_freestyle { get; set; }
        public string mma_fighting_style_muay_thai { get; set; }
        public string mma_fighting_style_boxing { get; set; }
        public string mma_fighting_style_brazilian_jiu_jitsu { get; set; }
        public string mma_fighting_style_jiu_jitsu { get; set; }
        public string mma_fighting_style_judo { get; set; }
        public string mma_fighting_style_karate { get; set; }
        public string mma_fighting_style_kickboxing { get; set; }
        public string mma_fighting_style_kung_fu { get; set; }
        public string mma_fighting_style_taekwondo { get; set; }
        public string mma_fighting_style_wrestling { get; set; }
        public string mma_grappling_per_min_description { get; set; }
        public string mma_position_stats_description { get; set; }
        public string mma_grappling_description { get; set; }
        public string mma_position_stats_description_live { get; set; }
        public string mma_figter_details_since { get; set; }
        public string mma_career_stats { get; set; }
        public string mma_upcoming_fight { get; set; }
        public string tennis_seeded_player { get; set; }
        public string tennis_seedings_title { get; set; }
        public string crowdsourcing_unofficial_result { get; set; }
        public string crowdsourcing_confirmation_alert { get; set; }
        public string crowdsourcing_displaying_result_title { get; set; }
        public string crowdsourcing_displaying_result_info_text { get; set; }
        public string control_in_clinch_position { get; set; }
        public string toto_promo_text { get; set; }
        public string toto_promo_button { get; set; }
        public string new_sport_available_info { get; set; }
        public string basketball_salary_cap { get; set; }
        public string basketball_salary_cap_maximum { get; set; }
        public string basketball_salary_luxury_tax_threshold { get; set; }
        public string basketball_salary_players_signed { get; set; }
        public string basketball_salary_active_cap { get; set; }
        public string basketball_salary_total_cap { get; set; }
        public string basketball_salary_cap_space { get; set; }
        public string new_feature_info_text { get; set; }
        public string basketball_salary_cap_onboarding_text { get; set; }
        public string top_players_rating_criteria_info { get; set; }
        public string send_feedback { get; set; }
        public string form_required_field { get; set; }
        public string form_describe_issue { get; set; }
        public string form_min_characters { get; set; }
        public string form_upload_screenshot { get; set; }
        public string form_submit_success { get; set; }
        public string form_feedback_logged_in { get; set; }
        public string form_your_email { get; set; }
        public string send { get; set; }
        public string quick_find { get; set; }
        public string young_rider { get; set; }
        public string general_classification_short { get; set; }
        public string young { get; set; }
        public string sprint { get; set; }
        public string climb { get; set; }
        public string stages { get; set; }
        public string no_data { get; set; }
        public string error_max_fields { get; set; }
        public string attack_momentum_title { get; set; }
        public string chatBannertitle { get; set; }
        public string chatBannersubtitle { get; set; }
        public string chatBannerqrTitle { get; set; }
        public string chatBannerappsTitle { get; set; }
        public string featured { get; set; }
        public string writeAMessage { get; set; }
        public string chatBannermodalTitle { get; set; }
        public string chatBannermodalSubtitle { get; set; }
        public string chatBannermodalItem1 { get; set; }
        public string chatBannermodalItem2 { get; set; }
        public string chatBannermodalItem3 { get; set; }
        public string chatBannermodalItem4 { get; set; }
        public string chatBannerjoinNow { get; set; }
        public string basicmoderator { get; set; }
        public string chatBannermessage1 { get; set; }
        public string chatBannermessage2 { get; set; }
        public string chatBannermessage3 { get; set; }
        public string chatBannermessage4 { get; set; }
        public string chatBannerjoinTheChat { get; set; }
    }

    public class Routes
    {
        public string routerankings { get; set; }
        public string routeuser { get; set; }
        public string routeuserlogin { get; set; }
        public string routeusernotificationSettings { get; set; }
        public string routetournament { get; set; }
        public string routetournamentstandingsembed { get; set; }
        public string routeuniqueTournament { get; set; }
        public string routeuniqueTournamenttotwembed { get; set; }
        public string routeteam { get; set; }
        public string routeplayer { get; set; }
        public string routemanager { get; set; }
        public string routereferee { get; set; }
        public string routestageSport { get; set; }
        public string routestageSportrace { get; set; }
        public string routestageSportuniqueStage { get; set; }
        public string routemma { get; set; }
        public string routemmaorganisation { get; set; }
        public string routemmafightnight { get; set; }
        public string routefighter { get; set; }
        public string routefavorites { get; set; }
        public string routeeventList { get; set; }
        public string routeeventListdate { get; set; }
        public string routeeventListcategory { get; set; }
        public string routebetting { get; set; }
        public string routeevent { get; set; }
        public string routeeventHl { get; set; }
        public string routeeventattackMomentumembed { get; set; }
        public string routeeventlineupsembed { get; set; }
        public string routecookiesPolicy { get; set; }
        public string routeprivacyPolicy { get; set; }
        public string routeembedplayer { get; set; }
        public string routepickem { get; set; }
        public string routepickemleaderboard { get; set; }
        public string routeembedpickemleaderboard { get; set; }
        public string routepickempreview { get; set; }
        public string routeembedpickem { get; set; }
        public string routedriver { get; set; }
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string esports { get; set; }
        public string mma { get; set; }
    }

    public class Paths
    {
        public string robots { get; set; }
        public string cookiesPolicy { get; set; }
        public string privacyPolicy { get; set; }
        public string favorites { get; set; }
        public string betting { get; set; }
        public string pickempreview { get; set; }
        public string pickem { get; set; }
        public string pickemleaderboard { get; set; }
        public string embedpickemleaderboard { get; set; }
        public string embedpickem { get; set; }
        public string embedplayer { get; set; }
        public string tournamentstandingsembed { get; set; }
        public string stageSport { get; set; }
        public string stageSportuniqueStage { get; set; }
        public string stageSportrace { get; set; }
        public string mma { get; set; }
        public string mmaorganisation { get; set; }
        public string mmafightnight { get; set; }
        public string manager { get; set; }
        public string referee { get; set; }
        public string driver { get; set; }
        public string fighter { get; set; }
        public string team { get; set; }
        public string player { get; set; }
        public string uniqueTournament { get; set; }
        public string tournament { get; set; }
        public string usernotificationSettings { get; set; }
        public string userlogin { get; set; }
        public string user { get; set; }
        public string eventList { get; set; }
        public string eventListdate { get; set; }
        public string eventListcategory { get; set; }
        public string _event { get; set; }
        public string eventHl { get; set; }
        public string rankings { get; set; }
        public string eventattackMomentumembed { get; set; }
        public string eventlineupsembed { get; set; }
        public string uniqueTournamenttotwembed { get; set; }
    }

    public class Sporttranslations
    {
        public En en { get; set; }
        public Hr hr { get; set; }
        public It it { get; set; }
        public Es es { get; set; }
        public Pt pt { get; set; }
        public De de { get; set; }
        public Fr fr { get; set; }
        public Pl pl { get; set; }
        public Hu hu { get; set; }
        public Da da { get; set; }
        public Tr tr { get; set; }
        public Ru ru { get; set; }
        public Nl nl { get; set; }
        public Id id { get; set; }
        public El el { get; set; }
        public Sv sv { get; set; }
        public Zh zh { get; set; }
        public Sr sr { get; set; }
        public Sl sl { get; set; }
        public Ro ro { get; set; }
        public No no { get; set; }
        public Hi hi { get; set; }
        public EnUs enus { get; set; }
        public PtPt ptpt { get; set; }
        public Cs cs { get; set; }
        public Sk sk { get; set; }
        public Bn bn { get; set; }
        public Ar ar { get; set; }
    }

    public class En
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Hr
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class It
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Es
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Pt
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class De
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Fr
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Pl
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Hu
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Da
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Tr
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Ru
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Nl
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Id
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class El
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Sv
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Zh
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Sr
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Sl
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Ro
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class No
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Hi
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class EnUs
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class PtPt
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Cs
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Sk
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Bn
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Ar
    {
        public string americanfootball { get; set; }
        public string aussierules { get; set; }
        public string badminton { get; set; }
        public string bandy { get; set; }
        public string baseball { get; set; }
        public string basketball { get; set; }
        public string cricket { get; set; }
        public string darts { get; set; }
        public string floorball { get; set; }
        public string football { get; set; }
        public string futsal { get; set; }
        public string handball { get; set; }
        public string icehockey { get; set; }
        public string rugby { get; set; }
        public string snooker { get; set; }
        public string tennis { get; set; }
        public string volleyball { get; set; }
        public string waterpolo { get; set; }
        public string tabletennis { get; set; }
        public string beachvolley { get; set; }
        public string esports { get; set; }
        public string motorsport { get; set; }
        public string cycling { get; set; }
        public string mma { get; set; }
    }

    public class Translatedroute
    {
        public string en { get; set; }
        public string hr { get; set; }
        public string it { get; set; }
        public string es { get; set; }
        public string pt { get; set; }
        public string de { get; set; }
        public string fr { get; set; }
        public string pl { get; set; }
        public string hu { get; set; }
        public string da { get; set; }
        public string tr { get; set; }
        public string ru { get; set; }
        public string nl { get; set; }
        public string id { get; set; }
        public string el { get; set; }
        public string sv { get; set; }
        public string zh { get; set; }
        public string sr { get; set; }
        public string sl { get; set; }
        public string ro { get; set; }
        public string no { get; set; }
        public string hi { get; set; }
        public string enus { get; set; }
        public string ptpt { get; set; }
        public string cs { get; set; }
        public string sk { get; set; }
        public string bn { get; set; }
        public string ar { get; set; }
    }

    public class Initialstate
    {
        public Uicontrols uicontrols { get; set; }
        public Locale locale { get; set; }
        public Odds odds { get; set; }
        public L10n l10n { get; set; }
        public Auth auth { get; set; }
        public Votes votes { get; set; }
        public Favorites favorites { get; set; }
        public Pinnedleagues pinnedLeagues { get; set; }
    }

    public class Uicontrols
    {
        public object activeSport { get; set; }
        public object activeWidgetEvent { get; set; }
        public Notificationsettings notificationSettings { get; set; }
        public Favoritesui favoritesUI { get; set; }
        public bool showListOdds { get; set; }
        public bool showLogoutPopover { get; set; }
        public Showallbydate showAllByDate { get; set; }
        public bool is18PlusConfirmed { get; set; }
        public object siteBettingAgeConfirmed { get; set; }
        public Surveys surveys { get; set; }
        public bool isFooterHidden { get; set; }
        public bool isMenuOpen { get; set; }
    }

    public class Notificationsettings
    {
        public bool isEnabled { get; set; }
        public bool isNotificationPermissionLoading { get; set; }
    }

    public class Favoritesui
    {
        public bool groupFavoritesByTournament { get; set; }
        public bool isSyncingFavorites { get; set; }
    }

    public class Showallbydate
    {
    }

    public class Surveys
    {
    }

    public class Locale
    {
        public string selectedLocale { get; set; }
        public string geoIPAlpha2 { get; set; }
        public Translatedroute1 translatedRoute { get; set; }
    }

    public class Translatedroute1
    {
        public string en { get; set; }
        public string hr { get; set; }
        public string it { get; set; }
        public string es { get; set; }
        public string pt { get; set; }
        public string de { get; set; }
        public string fr { get; set; }
        public string pl { get; set; }
        public string hu { get; set; }
        public string da { get; set; }
        public string tr { get; set; }
        public string ru { get; set; }
        public string nl { get; set; }
        public string id { get; set; }
        public string el { get; set; }
        public string sv { get; set; }
        public string zh { get; set; }
        public string sr { get; set; }
        public string sl { get; set; }
        public string ro { get; set; }
        public string no { get; set; }
        public string hi { get; set; }
        public string enus { get; set; }
        public string ptpt { get; set; }
        public string cs { get; set; }
        public string sk { get; set; }
        public string bn { get; set; }
        public string ar { get; set; }
    }

    public class Odds
    {
        public string type { get; set; }
        public object selectedProviderId { get; set; }
        public bool isOddsTypeSet { get; set; }
    }

    public class L10n
    {
        public bool displayInverseHomeAwayTeams { get; set; }
    }

    public class Auth
    {
        public Notificationsettings1 notificationSettings { get; set; }
        public bool notificationSettingsLoading { get; set; }
    }

    public class Notificationsettings1
    {
        public string[] football { get; set; }
        public string[] basketball { get; set; }
        public string[] tennis { get; set; }
        public string[] icehockey { get; set; }
        public string[] handball { get; set; }
        public string[] baseball { get; set; }
        public string[] americanfootball { get; set; }
        public string[] darts { get; set; }
        public string[] rugby { get; set; }
        public string[] snooker { get; set; }
        public string[] volleyball { get; set; }
        public string[] waterpolo { get; set; }
        public string[] futsal { get; set; }
        public string[] aussierules { get; set; }
        public string[] cricket { get; set; }
        public string[] badminton { get; set; }
        public string[] floorball { get; set; }
        public string[] bandy { get; set; }
        public string[] tabletennis { get; set; }
        public string[] beachvolley { get; set; }
        public string[] mma { get; set; }
        public string[] players { get; set; }
    }

    public class Votes
    {
    }

    public class Favorites
    {
        public Lists lists { get; set; }
        public Events events { get; set; }
        public Teams teams { get; set; }
        public Tournaments tournaments { get; set; }
        public Players players { get; set; }
    }

    public class Lists
    {
        public object[] teams { get; set; }
        public object[] tournaments { get; set; }
        public object[] players { get; set; }
        public object[] events { get; set; }
        public object[] mutedEvents { get; set; }
    }

    public class Events
    {
    }

    public class Teams
    {
    }

    public class Tournaments
    {
    }

    public class Players
    {
    }

    public class Pinnedleagues
    {
        public object[] user { get; set; }
        public Defaultforcountry defaultForCountry { get; set; }
    }

    public class Defaultforcountry
    {
    }

    public class Footerevent
    {
        public Tournament tournament { get; set; }
        public string customId { get; set; }
        public Status status { get; set; }
        public Hometeam homeTeam { get; set; }
        public Awayteam awayTeam { get; set; }
        public Homescore homeScore { get; set; }
        public Awayscore awayScore { get; set; }
        public int id { get; set; }
        public int startTimestamp { get; set; }
        public string slug { get; set; }
        public bool finalResultOnly { get; set; }
    }

    public class Tournament
    {
        public string name { get; set; }
        public string slug { get; set; }
        public Category3 category { get; set; }
        public Uniquetournament2 uniqueTournament { get; set; }
        public int priority { get; set; }
        public int id { get; set; }
    }

    public class Category3
    {
        public string name { get; set; }
        public string slug { get; set; }
        public Sport6 sport { get; set; }
        public int id { get; set; }
        public string flag { get; set; }
        public string alpha2 { get; set; }
    }

    public class Sport6
    {
        public string name { get; set; }
        public string slug { get; set; }
        public int id { get; set; }
    }

    public class Uniquetournament2
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string primaryColorHex { get; set; }
        public string secondaryColorHex { get; set; }
        public Category4 category { get; set; }
        public int userCount { get; set; }
        public int id { get; set; }
        public Country4 country { get; set; }
        public bool displayInverseHomeAwayTeams { get; set; }
        public int tennisPoints { get; set; }
        public bool hasDownDistance { get; set; }
    }

    public class Category4
    {
        public string name { get; set; }
        public string slug { get; set; }
        public Sport7 sport { get; set; }
        public int id { get; set; }
        public string flag { get; set; }
        public string alpha2 { get; set; }
    }

    public class Sport7
    {
        public string name { get; set; }
        public string slug { get; set; }
        public int id { get; set; }
    }

    public class Country4
    {
    }

    public class Status
    {
        public int code { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hometeam
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string shortName { get; set; }
        public string gender { get; set; }
        public Sport8 sport { get; set; }
        public int userCount { get; set; }
        public string nameCode { get; set; }
        public bool disabled { get; set; }
        public bool national { get; set; }
        public int type { get; set; }
        public int id { get; set; }
        public Country5 country { get; set; }
        public Teamcolors3 teamColors { get; set; }
        public int ranking { get; set; }
    }

    public class Sport8
    {
        public string name { get; set; }
        public string slug { get; set; }
        public int id { get; set; }
    }

    public class Country5
    {
        public string alpha2 { get; set; }
        public string name { get; set; }
    }

    public class Teamcolors3
    {
        public string primary { get; set; }
        public string secondary { get; set; }
        public string text { get; set; }
    }

    public class Awayteam
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string shortName { get; set; }
        public string gender { get; set; }
        public Sport9 sport { get; set; }
        public int userCount { get; set; }
        public string nameCode { get; set; }
        public bool disabled { get; set; }
        public bool national { get; set; }
        public int type { get; set; }
        public int id { get; set; }
        public Country6 country { get; set; }
        public Teamcolors4 teamColors { get; set; }
        public int ranking { get; set; }
    }

    public class Sport9
    {
        public string name { get; set; }
        public string slug { get; set; }
        public int id { get; set; }
    }

    public class Country6
    {
        public string alpha2 { get; set; }
        public string name { get; set; }
    }

    public class Teamcolors4
    {
        public string primary { get; set; }
        public string secondary { get; set; }
        public string text { get; set; }
    }

    public class Homescore
    {
    }

    public class Awayscore
    {
    }

    public class Query
    {
        public string sport { get; set; }
        public string category { get; set; }
        public string tournament { get; set; }
        public string id { get; set; }
        public _Routeparams _routeParams { get; set; }
    }

    public class _Routeparams
    {
        public string sport { get; set; }
        public string category { get; set; }
        public string tournament { get; set; }
        public string id { get; set; }
    }
}

