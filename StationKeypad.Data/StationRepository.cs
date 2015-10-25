using System.Collections.Generic;
using StationKeypad.DataModel;

namespace StationKeypad.Data
{
	public class StationRepository : IStationRepository
	{
		public List<Station> GetAllInOrder()
		{
			return new List<Station>
			{
				new Station
				{
					Name = "Abbey Wood",
					Code = "ABW"
				},
				new Station
				{
					Name = "Aber",
					Code = "ABE"
				},
				new Station
				{
					Name = "Abercynon",
					Code = "ACY"
				},
				new Station
				{
					Name = "Aberdare",
					Code = "ABA"
				},
				new Station
				{
					Name = "Aberdeen",
					Code = "ABD"
				},
				new Station
				{
					Name = "Aberdour",
					Code = "AUR"
				},
				new Station
				{
					Name = "Aberdovey",
					Code = "AVY"
				},
				new Station
				{
					Name = "Abererch",
					Code = "ABH"
				},
				new Station
				{
					Name = "Abergavenny",
					Code = "AGV"
				},
				new Station
				{
					Name = "Abergele & Pensarn",
					Code = "AGL"
				},
				new Station
				{
					Name = "Aberystwyth",
					Code = "AYW"
				},
				new Station
				{
					Name = "Accrington",
					Code = "ACR"
				},
				new Station
				{
					Name = "Achanalt",
					Code = "AAT"
				},
				new Station
				{
					Name = "Achnasheen",
					Code = "ACN"
				},
				new Station
				{
					Name = "Achnashellach",
					Code = "ACH"
				},
				new Station
				{
					Name = "Acklington",
					Code = "ACK"
				},
				new Station
				{
					Name = "Acle",
					Code = "ACL"
				},
				new Station
				{
					Name = "Acocks Green",
					Code = "ACG"
				},
				new Station
				{
					Name = "Acton Bridge (Cheshire)",
					Code = "ACB"
				},
				new Station
				{
					Name = "Acton Central",
					Code = "ACC"
				},
				new Station
				{
					Name = "Acton Main Line",
					Code = "AML"
				},
				new Station
				{
					Name = "Adderley Park",
					Code = "ADD"
				},
				new Station
				{
					Name = "Addiewell",
					Code = "ADW"
				},
				new Station
				{
					Name = "Addlestone",
					Code = "ASN"
				},
				new Station
				{
					Name = "Adisham",
					Code = "ADM"
				},
				new Station
				{
					Name = "Adlington (Cheshire)",
					Code = "ADC"
				},
				new Station
				{
					Name = "Adlington (Lancs)",
					Code = "ADL"
				},
				new Station
				{
					Name = "Adwick",
					Code = "AWK"
				},
				new Station
				{
					Name = "Aigburth",
					Code = "AIG"
				},
				new Station
				{
					Name = "Ainsdale",
					Code = "ANS"
				},
				new Station
				{
					Name = "Aintree",
					Code = "AIN"
				},
				new Station
				{
					Name = "Airbles",
					Code = "AIR"
				},
				new Station
				{
					Name = "Airdrie",
					Code = "ADR"
				},
				new Station
				{
					Name = "Albany Park",
					Code = "AYP"
				},
				new Station
				{
					Name = "Albrighton",
					Code = "ALB"
				},
				new Station
				{
					Name = "Alderley Edge",
					Code = "ALD"
				},
				new Station
				{
					Name = "Aldermaston",
					Code = "AMT"
				},
				new Station
				{
					Name = "Aldershot",
					Code = "AHT"
				},
				new Station
				{
					Name = "Aldrington",
					Code = "AGT"
				},
				new Station
				{
					Name = "Alexandra Palace",
					Code = "AAP"
				},
				new Station
				{
					Name = "Alexandra Parade",
					Code = "AXP"
				},
				new Station
				{
					Name = "Alexandria",
					Code = "ALX"
				},
				new Station
				{
					Name = "Alfreton",
					Code = "ALF"
				},
				new Station
				{
					Name = "Allens West",
					Code = "ALW"
				},
				new Station
				{
					Name = "Alloa",
					Code = "ALO"
				},
				new Station
				{
					Name = "Alness",
					Code = "ASS"
				},
				new Station
				{
					Name = "Alnmouth",
					Code = "ALM"
				},
				new Station
				{
					Name = "Alresford (Essex)",
					Code = "ALR"
				},
				new Station
				{
					Name = "Alsager",
					Code = "ASG"
				},
				new Station
				{
					Name = "Althorne (Essex)",
					Code = "ALN"
				},
				new Station
				{
					Name = "Althorpe",
					Code = "ALP"
				},
				new Station
				{
					Name = "Altnabreac",
					Code = "ABC"
				},
				new Station
				{
					Name = "Alton",
					Code = "AON"
				},
				new Station
				{
					Name = "Altrincham",
					Code = "ALT"
				},
				new Station
				{
					Name = "Alvechurch",
					Code = "ALV"
				},
				new Station
				{
					Name = "Ambergate",
					Code = "AMB"
				},
				new Station
				{
					Name = "Amberley",
					Code = "AMY"
				},
				new Station
				{
					Name = "Amersham",
					Code = "AMR"
				},
				new Station
				{
					Name = "Ammanford",
					Code = "AMF"
				},
				new Station
				{
					Name = "Ancaster",
					Code = "ANC"
				},
				new Station
				{
					Name = "Anderston",
					Code = "AND"
				},
				new Station
				{
					Name = "Andover",
					Code = "ADV"
				},
				new Station
				{
					Name = "Anerley",
					Code = "ANZ"
				},
				new Station
				{
					Name = "Angel Road",
					Code = "AGR"
				},
				new Station
				{
					Name = "Angmering",
					Code = "ANG"
				},
				new Station
				{
					Name = "Annan",
					Code = "ANN"
				},
				new Station
				{
					Name = "Anniesland",
					Code = "ANL"
				},
				new Station
				{
					Name = "Ansdell & Fairhaven",
					Code = "AFV"
				},
				new Station
				{
					Name = "Appleby",
					Code = "APP"
				},
				new Station
				{
					Name = "Appledore (Kent)",
					Code = "APD"
				},
				new Station
				{
					Name = "Appleford",
					Code = "APF"
				},
				new Station
				{
					Name = "Appley Bridge",
					Code = "APB"
				},
				new Station
				{
					Name = "Apsley",
					Code = "APS"
				},
				new Station
				{
					Name = "Arbroath",
					Code = "ARB"
				},
				new Station
				{
					Name = "Ardgay",
					Code = "ARD"
				},
				new Station
				{
					Name = "Ardlui",
					Code = "AUI"
				},
				new Station
				{
					Name = "Ardrossan Harbour",
					Code = "ADS"
				},
				new Station
				{
					Name = "Ardrossan South Beach",
					Code = "ASB"
				},
				new Station
				{
					Name = "Ardrossan Town",
					Code = "ADN"
				},
				new Station
				{
					Name = "Ardwick",
					Code = "ADK"
				},
				new Station
				{
					Name = "Argyle Street",
					Code = "AGS"
				},
				new Station
				{
					Name = "Arisaig",
					Code = "ARG"
				},
				new Station
				{
					Name = "Arlesey",
					Code = "ARL"
				},
				new Station
				{
					Name = "Armadale (West Lothian)",
					Code = "ARM"
				},
				new Station
				{
					Name = "Armathwaite",
					Code = "AWT"
				},
				new Station
				{
					Name = "Arnside",
					Code = "ARN"
				},
				new Station
				{
					Name = "Arram",
					Code = "ARR"
				},
				new Station
				{
					Name = "Arrochar & Tarbet",
					Code = "ART"
				},
				new Station
				{
					Name = "Arundel",
					Code = "ARU"
				},
				new Station
				{
					Name = "Ascot (Berks)",
					Code = "ACT"
				},
				new Station
				{
					Name = "Ascott-under-Wychwood",
					Code = "AUW"
				},
				new Station
				{
					Name = "Ash",
					Code = "ASH"
				},
				new Station
				{
					Name = "Ash Vale",
					Code = "AHV"
				},
				new Station
				{
					Name = "Ashburys",
					Code = "ABY"
				},
				new Station
				{
					Name = "Ashchurch for Tewkesbury",
					Code = "ASC"
				},
				new Station
				{
					Name = "Ashfield",
					Code = "ASF"
				},
				new Station
				{
					Name = "Ashford International",
					Code = "AFK"
				},
				new Station
				{
					Name = "Ashford International (Eurostar)",
					Code = "ASI"
				},
				new Station
				{
					Name = "Ashford (Surrey)",
					Code = "AFS"
				},
				new Station
				{
					Name = "Ashley",
					Code = "ASY"
				},
				new Station
				{
					Name = "Ashtead",
					Code = "AHD"
				},
				new Station
				{
					Name = "Ashton-under-Lyne",
					Code = "AHN"
				},
				new Station
				{
					Name = "Ashurst (Kent)",
					Code = "AHS"
				},
				new Station
				{
					Name = "Ashurst New Forest",
					Code = "ANF"
				},
				new Station
				{
					Name = "Ashwell & Morden",
					Code = "AWM"
				},
				new Station
				{
					Name = "Askam",
					Code = "ASK"
				},
				new Station
				{
					Name = "Aslockton",
					Code = "ALK"
				},
				new Station
				{
					Name = "Aspatria",
					Code = "ASP"
				},
				new Station
				{
					Name = "Aspley Guise",
					Code = "APG"
				},
				new Station
				{
					Name = "Aston",
					Code = "AST"
				},
				new Station
				{
					Name = "Atherstone",
					Code = "ATH"
				},
				new Station
				{
					Name = "Atherton (Manchester)",
					Code = "ATN"
				},
				new Station
				{
					Name = "Attadale",
					Code = "ATT"
				},
				new Station
				{
					Name = "Attenborough",
					Code = "ATB"
				},
				new Station
				{
					Name = "Attleborough",
					Code = "ATL"
				},
				new Station
				{
					Name = "Auchinleck",
					Code = "AUK"
				},
				new Station
				{
					Name = "Audley End",
					Code = "AUD"
				},
				new Station
				{
					Name = "Aughton Park",
					Code = "AUG"
				},
				new Station
				{
					Name = "Aviemore",
					Code = "AVM"
				},
				new Station
				{
					Name = "Avoncliff",
					Code = "AVF"
				},
				new Station
				{
					Name = "Avonmouth",
					Code = "AVN"
				},
				new Station
				{
					Name = "Axminster",
					Code = "AXM"
				},
				new Station
				{
					Name = "Aylesbury",
					Code = "AYS"
				},
				new Station
				{
					Name = "Aylesbury Vale Parkway",
					Code = "AVP"
				},
				new Station
				{
					Name = "Aylesford",
					Code = "AYL"
				},
				new Station
				{
					Name = "Aylesham",
					Code = "AYH"
				},
				new Station
				{
					Name = "Ayr",
					Code = "AYR"
				},
				new Station
				{
					Name = "Bache",
					Code = "BAC"
				},
				new Station
				{
					Name = "Baglan",
					Code = "BAJ"
				},
				new Station
				{
					Name = "Bagshot",
					Code = "BAG"
				},
				new Station
				{
					Name = "Baildon",
					Code = "BLD"
				},
				new Station
				{
					Name = "Baillieston",
					Code = "BIO"
				},
				new Station
				{
					Name = "Balcombe",
					Code = "BAB"
				},
				new Station
				{
					Name = "Baldock",
					Code = "BDK"
				},
				new Station
				{
					Name = "Balham",
					Code = "BAL"
				},
				new Station
				{
					Name = "Balloch",
					Code = "BHC"
				},
				new Station
				{
					Name = "Balmossie",
					Code = "BSI"
				},
				new Station
				{
					Name = "Bamber Bridge",
					Code = "BMB"
				},
				new Station
				{
					Name = "Bamford",
					Code = "BAM"
				},
				new Station
				{
					Name = "Banavie",
					Code = "BNV"
				},
				new Station
				{
					Name = "Banbury",
					Code = "BAN"
				},
				new Station
				{
					Name = "Bangor (Gwynedd)",
					Code = "BNG"
				},
				new Station
				{
					Name = "Bank Hall",
					Code = "BAH"
				},
				new Station
				{
					Name = "Banstead",
					Code = "BAD"
				},
				new Station
				{
					Name = "Barassie",
					Code = "BSS"
				},
				new Station
				{
					Name = "Barbican",
					Code = "ZBB"
				},
				new Station
				{
					Name = "Bardon Mill",
					Code = "BLL"
				},
				new Station
				{
					Name = "Bare Lane",
					Code = "BAR"
				},
				new Station
				{
					Name = "Bargeddie",
					Code = "BGI"
				},
				new Station
				{
					Name = "Bargoed",
					Code = "BGD"
				},
				new Station
				{
					Name = "Barking",
					Code = "BKG"
				},
				new Station
				{
					Name = "Barking Underground",
					Code = "ZBK"
				},
				new Station
				{
					Name = "Barlaston",
					Code = "BRT"
				},
				new Station
				{
					Name = "Barming",
					Code = "BMG"
				},
				new Station
				{
					Name = "Barmouth",
					Code = "BRM"
				},
				new Station
				{
					Name = "Barnehurst",
					Code = "BNH"
				},
				new Station
				{
					Name = "Barnes",
					Code = "BNS"
				},
				new Station
				{
					Name = "Barnes Bridge",
					Code = "BNI"
				},
				new Station
				{
					Name = "Barnetby",
					Code = "BTB"
				},
				new Station
				{
					Name = "Barnham",
					Code = "BAA"
				},
				new Station
				{
					Name = "Barnhill",
					Code = "BNL"
				},
				new Station
				{
					Name = "Barnsley",
					Code = "BNY"
				},
				new Station
				{
					Name = "Barnstaple",
					Code = "BNP"
				},
				new Station
				{
					Name = "Barnt Green",
					Code = "BTG"
				},
				new Station
				{
					Name = "Barrhead",
					Code = "BRR"
				},
				new Station
				{
					Name = "Barrhill",
					Code = "BRL"
				},
				new Station
				{
					Name = "Barrow Haven",
					Code = "BAV"
				},
				new Station
				{
					Name = "Barrow-in-Furness",
					Code = "BIF"
				},
				new Station
				{
					Name = "Barrow-Upon-Soar",
					Code = "BWS"
				},
				new Station
				{
					Name = "Barry",
					Code = "BRY"
				},
				new Station
				{
					Name = "Barry Docks",
					Code = "BYD"
				},
				new Station
				{
					Name = "Barry Island",
					Code = "BYI"
				},
				new Station
				{
					Name = "Barry Links",
					Code = "BYL"
				},
				new Station
				{
					Name = "Barton-on-Humber",
					Code = "BAU"
				},
				new Station
				{
					Name = "Basildon",
					Code = "BSO"
				},
				new Station
				{
					Name = "Basingstoke",
					Code = "BSK"
				},
				new Station
				{
					Name = "Bat & Ball",
					Code = "BBL"
				},
				new Station
				{
					Name = "Bath Spa",
					Code = "BTH"
				},
				new Station
				{
					Name = "Bathgate",
					Code = "BHG"
				},
				new Station
				{
					Name = "Batley",
					Code = "BTL"
				},
				new Station
				{
					Name = "Battersby",
					Code = "BTT"
				},
				new Station
				{
					Name = "Battersea Park",
					Code = "BAK"
				},
				new Station
				{
					Name = "Battle",
					Code = "BAT"
				},
				new Station
				{
					Name = "Battlesbridge",
					Code = "BLB"
				},
				new Station
				{
					Name = "Bayford",
					Code = "BAY"
				},
				new Station
				{
					Name = "Beaconsfield",
					Code = "BCF"
				},
				new Station
				{
					Name = "Bearley",
					Code = "BER"
				},
				new Station
				{
					Name = "Bearsden",
					Code = "BRN"
				},
				new Station
				{
					Name = "Bearsted",
					Code = "BSD"
				},
				new Station
				{
					Name = "Beasdale",
					Code = "BSL"
				},
				new Station
				{
					Name = "Beaulieu Road",
					Code = "BEU"
				},
				new Station
				{
					Name = "Beauly",
					Code = "BEL"
				},
				new Station
				{
					Name = "Bebington",
					Code = "BEB"
				},
				new Station
				{
					Name = "Beccles",
					Code = "BCC"
				},
				new Station
				{
					Name = "Beckenham Hill",
					Code = "BEC"
				},
				new Station
				{
					Name = "Beckenham Junction",
					Code = "BKJ"
				},
				new Station
				{
					Name = "Bedford",
					Code = "BDM"
				},
				new Station
				{
					Name = "Bedford St Johns",
					Code = "BSJ"
				},
				new Station
				{
					Name = "Bedhampton",
					Code = "BDH"
				},
				new Station
				{
					Name = "Bedminster",
					Code = "BMT"
				},
				new Station
				{
					Name = "Bedworth",
					Code = "BEH"
				},
				new Station
				{
					Name = "Bedwyn",
					Code = "BDW"
				},
				new Station
				{
					Name = "Beeston",
					Code = "BEE"
				},
				new Station
				{
					Name = "Bekesbourne",
					Code = "BKS"
				},
				new Station
				{
					Name = "Belle Vue",
					Code = "BLV"
				},
				new Station
				{
					Name = "Bellgrove",
					Code = "BLG"
				},
				new Station
				{
					Name = "Bellingham",
					Code = "BGM"
				},
				new Station
				{
					Name = "Bellshill",
					Code = "BLH"
				},
				new Station
				{
					Name = "Belmont",
					Code = "BLM"
				},
				new Station
				{
					Name = "Belper",
					Code = "BLP"
				},
				new Station
				{
					Name = "Beltring",
					Code = "BEG"
				},
				new Station
				{
					Name = "Belvedere",
					Code = "BVD"
				},
				new Station
				{
					Name = "Bempton",
					Code = "BEM"
				},
				new Station
				{
					Name = "Ben Rhydding",
					Code = "BEY"
				},
				new Station
				{
					Name = "Benfleet",
					Code = "BEF"
				},
				new Station
				{
					Name = "Bentham",
					Code = "BEN"
				},
				new Station
				{
					Name = "Bentley (Hants)",
					Code = "BTY"
				},
				new Station
				{
					Name = "Bentley (South Yorks)",
					Code = "BYK"
				},
				new Station
				{
					Name = "Bere Alston",
					Code = "BAS"
				},
				new Station
				{
					Name = "Bere Ferrers",
					Code = "BFE"
				},
				new Station
				{
					Name = "Berkhamsted",
					Code = "BKM"
				},
				new Station
				{
					Name = "Berkswell",
					Code = "BKW"
				},
				new Station
				{
					Name = "Berney Arms",
					Code = "BYA"
				},
				new Station
				{
					Name = "Berry Brow",
					Code = "BBW"
				},
				new Station
				{
					Name = "Berrylands",
					Code = "BRS"
				},
				new Station
				{
					Name = "Berwick (Sussex)",
					Code = "BRK"
				},
				new Station
				{
					Name = "Berwick-upon-Tweed",
					Code = "BWK"
				},
				new Station
				{
					Name = "Bescar Lane",
					Code = "BES"
				},
				new Station
				{
					Name = "Bescot Stadium",
					Code = "BSC"
				},
				new Station
				{
					Name = "Betchworth",
					Code = "BTO"
				},
				new Station
				{
					Name = "Bethnal Green",
					Code = "BET"
				},
				new Station
				{
					Name = "Betws-y-Coed",
					Code = "BYC"
				},
				new Station
				{
					Name = "Beverley",
					Code = "BEV"
				},
				new Station
				{
					Name = "Bexhill",
					Code = "BEX"
				},
				new Station
				{
					Name = "Bexley",
					Code = "BXY"
				},
				new Station
				{
					Name = "Bexleyheath",
					Code = "BXH"
				},
				new Station
				{
					Name = "Bicester North",
					Code = "BCS"
				},
				new Station
				{
					Name = "Bicester Town",
					Code = "BIT"
				},
				new Station
				{
					Name = "Bickley",
					Code = "BKL"
				},
				new Station
				{
					Name = "Bidston",
					Code = "BID"
				},
				new Station
				{
					Name = "Biggleswade",
					Code = "BIW"
				},
				new Station
				{
					Name = "Bilbrook",
					Code = "BBK"
				},
				new Station
				{
					Name = "Billericay",
					Code = "BIC"
				},
				new Station
				{
					Name = "Billingham (Cleveland)",
					Code = "BIL"
				},
				new Station
				{
					Name = "Billingshurst",
					Code = "BIG"
				},
				new Station
				{
					Name = "Bingham",
					Code = "BIN"
				},
				new Station
				{
					Name = "Bingley",
					Code = "BIY"
				},
				new Station
				{
					Name = "Birchgrove",
					Code = "BCG"
				},
				new Station
				{
					Name = "Birchington-on-sea",
					Code = "BCH"
				},
				new Station
				{
					Name = "Birchwood",
					Code = "BWD"
				},
				new Station
				{
					Name = "Birkbeck",
					Code = "BIK"
				},
				new Station
				{
					Name = "Birkdale",
					Code = "BDL"
				},
				new Station
				{
					Name = "Birkenhead Central",
					Code = "BKC"
				},
				new Station
				{
					Name = "Birkenhead Hamilton Square",
					Code = "BKQ"
				},
				new Station
				{
					Name = "Birkenhead North",
					Code = "BKN"
				},
				new Station
				{
					Name = "Birkenhead Park",
					Code = "BKP"
				},
				new Station
				{
					Name = "Birmingham International",
					Code = "BHI"
				},
				new Station
				{
					Name = "Birmingham Moor Street",
					Code = "BMO"
				},
				new Station
				{
					Name = "Birmingham New Street",
					Code = "BHM"
				},
				new Station
				{
					Name = "Birmingham Snow Hill",
					Code = "BSW"
				},
				new Station
				{
					Name = "Bishop Auckland",
					Code = "BIA"
				},
				new Station
				{
					Name = "Bishopbriggs",
					Code = "BBG"
				},
				new Station
				{
					Name = "Bishops Stortford",
					Code = "BIS"
				},
				new Station
				{
					Name = "Bishopstone (Sussex)",
					Code = "BIP"
				},
				new Station
				{
					Name = "Bishopton (Strathclyde)",
					Code = "BPT"
				},
				new Station
				{
					Name = "Bitterne",
					Code = "BTE"
				},
				new Station
				{
					Name = "Blackburn",
					Code = "BBN"
				},
				new Station
				{
					Name = "Blackheath",
					Code = "BKH"
				},
				new Station
				{
					Name = "Blackhorse Road",
					Code = "BHO"
				},
				new Station
				{
					Name = "Blackpool North",
					Code = "BPN"
				},
				new Station
				{
					Name = "Blackpool Pleasure Beach",
					Code = "BPB"
				},
				new Station
				{
					Name = "Blackpool South",
					Code = "BPS"
				},
				new Station
				{
					Name = "Blackridge",
					Code = "BKR"
				},
				new Station
				{
					Name = "Blackrod",
					Code = "BLK"
				},
				new Station
				{
					Name = "Blackwater",
					Code = "BAW"
				},
				new Station
				{
					Name = "Blaenau Ffestiniog",
					Code = "BFF"
				},
				new Station
				{
					Name = "Blair Atholl",
					Code = "BLA"
				},
				new Station
				{
					Name = "Blairhill",
					Code = "BAI"
				},
				new Station
				{
					Name = "Blake Street",
					Code = "BKT"
				},
				new Station
				{
					Name = "Blakedown",
					Code = "BKD"
				},
				new Station
				{
					Name = "Blantyre",
					Code = "BLT"
				},
				new Station
				{
					Name = "Blaydon",
					Code = "BLO"
				},
				new Station
				{
					Name = "Bleasby",
					Code = "BSB"
				},
				new Station
				{
					Name = "Bletchley",
					Code = "BLY"
				},
				new Station
				{
					Name = "Bloxwich",
					Code = "BLX"
				},
				new Station
				{
					Name = "Bloxwich North",
					Code = "BWN"
				},
				new Station
				{
					Name = "Blundellsands & Crosby",
					Code = "BLN"
				},
				new Station
				{
					Name = "Blythe Bridge",
					Code = "BYB"
				},
				new Station
				{
					Name = "Bodmin Parkway",
					Code = "BOD"
				},
				new Station
				{
					Name = "Bodorgan",
					Code = "BOR"
				},
				new Station
				{
					Name = "Bognor Regis",
					Code = "BOG"
				},
				new Station
				{
					Name = "Bogston",
					Code = "BGS"
				},
				new Station
				{
					Name = "Bolton",
					Code = "BON"
				},
				new Station
				{
					Name = "Bolton-on-Dearne",
					Code = "BTD"
				},
				new Station
				{
					Name = "Bookham",
					Code = "BKA"
				},
				new Station
				{
					Name = "Bootle (Cumbria)",
					Code = "BOC"
				},
				new Station
				{
					Name = "Bootle New Strand",
					Code = "BNW"
				},
				new Station
				{
					Name = "Bootle Oriel Road",
					Code = "BOT"
				},
				new Station
				{
					Name = "Bordesley",
					Code = "BBS"
				},
				new Station
				{
					Name = "Borough Green & Wrotham",
					Code = "BRG"
				},
				new Station
				{
					Name = "Borth",
					Code = "BRH"
				},
				new Station
				{
					Name = "Bosham",
					Code = "BOH"
				},
				new Station
				{
					Name = "Boston",
					Code = "BSN"
				},
				new Station
				{
					Name = "Botley",
					Code = "BOE"
				},
				new Station
				{
					Name = "Bottesford",
					Code = "BTF"
				},
				new Station
				{
					Name = "Bourne End",
					Code = "BNE"
				},
				new Station
				{
					Name = "Bournemouth",
					Code = "BMH"
				},
				new Station
				{
					Name = "Bournville",
					Code = "BRV"
				},
				new Station
				{
					Name = "Bow Brickhill",
					Code = "BWB"
				},
				new Station
				{
					Name = "Bowes Park",
					Code = "BOP"
				},
				new Station
				{
					Name = "Bowling",
					Code = "BWG"
				},
				new Station
				{
					Name = "Box Hill & Westhumble",
					Code = "BXW"
				},
				new Station
				{
					Name = "Bracknell",
					Code = "BCE"
				},
				new Station
				{
					Name = "Bradford Forster Square",
					Code = "BDQ"
				},
				new Station
				{
					Name = "Bradford Interchange",
					Code = "BDI"
				},
				new Station
				{
					Name = "Bradford-on-Avon",
					Code = "BOA"
				},
				new Station
				{
					Name = "Brading",
					Code = "BDN"
				},
				new Station
				{
					Name = "Braintree",
					Code = "BTR"
				},
				new Station
				{
					Name = "Braintree Freeport",
					Code = "BTP"
				},
				new Station
				{
					Name = "Bramhall",
					Code = "BML"
				},
				new Station
				{
					Name = "Bramley (Hants)",
					Code = "BMY"
				},
				new Station
				{
					Name = "Bramley (W Yorks)",
					Code = "BLE"
				},
				new Station
				{
					Name = "Brampton (Cumbria)",
					Code = "BMP"
				},
				new Station
				{
					Name = "Brampton (Suffolk)",
					Code = "BRP"
				},
				new Station
				{
					Name = "Branchton",
					Code = "BCN"
				},
				new Station
				{
					Name = "Brandon",
					Code = "BND"
				},
				new Station
				{
					Name = "Branksome",
					Code = "BSM"
				},
				new Station
				{
					Name = "Braystones (Cumbria)",
					Code = "BYS"
				},
				new Station
				{
					Name = "Bredbury",
					Code = "BDY"
				},
				new Station
				{
					Name = "Breich",
					Code = "BRC"
				},
				new Station
				{
					Name = "Brentford",
					Code = "BFD"
				},
				new Station
				{
					Name = "Brentwood",
					Code = "BRE"
				},
				new Station
				{
					Name = "Bricket Wood",
					Code = "BWO"
				},
				new Station
				{
					Name = "Bridge of Allan",
					Code = "BEA"
				},
				new Station
				{
					Name = "Bridge of Orchy",
					Code = "BRO"
				},
				new Station
				{
					Name = "Bridgend",
					Code = "BGN"
				},
				new Station
				{
					Name = "Bridgeton",
					Code = "BDG"
				},
				new Station
				{
					Name = "Bridgwater",
					Code = "BWT"
				},
				new Station
				{
					Name = "Bridlington",
					Code = "BDT"
				},
				new Station
				{
					Name = "Brierfield",
					Code = "BRF"
				},
				new Station
				{
					Name = "Brigg",
					Code = "BGG"
				},
				new Station
				{
					Name = "Brighouse",
					Code = "BGH"
				},
				new Station
				{
					Name = "Brighton (East Sussex)",
					Code = "BTN"
				},
				new Station
				{
					Name = "Brimsdown",
					Code = "BMD"
				},
				new Station
				{
					Name = "Brinnington",
					Code = "BNT"
				},
				new Station
				{
					Name = "Bristol Parkway",
					Code = "BPW"
				},
				new Station
				{
					Name = "Bristol Temple Meads",
					Code = "BRI"
				},
				new Station
				{
					Name = "Brithdir",
					Code = "BHD"
				},
				new Station
				{
					Name = "Briton Ferry",
					Code = "BNF"
				},
				new Station
				{
					Name = "Brixton",
					Code = "BRX"
				},
				new Station
				{
					Name = "Broad Green",
					Code = "BGE"
				},
				new Station
				{
					Name = "Broadbottom",
					Code = "BDB"
				},
				new Station
				{
					Name = "Broadstairs",
					Code = "BSR"
				},
				new Station
				{
					Name = "Brockenhurst",
					Code = "BCU"
				},
				new Station
				{
					Name = "Brockholes",
					Code = "BHS"
				},
				new Station
				{
					Name = "Brockley",
					Code = "BCY"
				},
				new Station
				{
					Name = "Bromborough",
					Code = "BOM"
				},
				new Station
				{
					Name = "Bromborough Rake",
					Code = "BMR"
				},
				new Station
				{
					Name = "Bromley Cross (Lancs)",
					Code = "BMC"
				},
				new Station
				{
					Name = "Bromley North",
					Code = "BMN"
				},
				new Station
				{
					Name = "Bromley South",
					Code = "BMS"
				},
				new Station
				{
					Name = "Bromsgrove",
					Code = "BMV"
				},
				new Station
				{
					Name = "Brondesbury",
					Code = "BSY"
				},
				new Station
				{
					Name = "Brondesbury Park",
					Code = "BSP"
				},
				new Station
				{
					Name = "Brookmans Park",
					Code = "BPK"
				},
				new Station
				{
					Name = "Brookwood",
					Code = "BKO"
				},
				new Station
				{
					Name = "Broome",
					Code = "BME"
				},
				new Station
				{
					Name = "Broomfleet",
					Code = "BMF"
				},
				new Station
				{
					Name = "Brora",
					Code = "BRA"
				},
				new Station
				{
					Name = "Brough",
					Code = "BUH"
				},
				new Station
				{
					Name = "Broughty Ferry",
					Code = "BYF"
				},
				new Station
				{
					Name = "Broxbourne",
					Code = "BXB"
				},
				new Station
				{
					Name = "Bruce Grove",
					Code = "BCV"
				},
				new Station
				{
					Name = "Brundall",
					Code = "BDA"
				},
				new Station
				{
					Name = "Brundall Gardens",
					Code = "BGA"
				},
				new Station
				{
					Name = "Brunstane",
					Code = "BSU"
				},
				new Station
				{
					Name = "Brunswick",
					Code = "BRW"
				},
				new Station
				{
					Name = "Bruton",
					Code = "BRU"
				},
				new Station
				{
					Name = "Bryn",
					Code = "BYN"
				},
				new Station
				{
					Name = "Buckenham (Norfolk)",
					Code = "BUC"
				},
				new Station
				{
					Name = "Buckley",
					Code = "BCK"
				},
				new Station
				{
					Name = "Bucknell",
					Code = "BUK"
				},
				new Station
				{
					Name = "Buckshaw Parkway",
					Code = "BSV"
				},
				new Station
				{
					Name = "Bugle",
					Code = "BGL"
				},
				new Station
				{
					Name = "Builth Road",
					Code = "BHR"
				},
				new Station
				{
					Name = "Bulwell",
					Code = "BLW"
				},
				new Station
				{
					Name = "Bures",
					Code = "BUE"
				},
				new Station
				{
					Name = "Burgess Hill",
					Code = "BUG"
				},
				new Station
				{
					Name = "Burley Park",
					Code = "BUY"
				},
				new Station
				{
					Name = "Burley-in-Wharfedale",
					Code = "BUW"
				},
				new Station
				{
					Name = "Burnage",
					Code = "BNA"
				},
				new Station
				{
					Name = "Burneside (Cumbria)",
					Code = "BUD"
				},
				new Station
				{
					Name = "Burnham (Bucks)",
					Code = "BNM"
				},
				new Station
				{
					Name = "Burnham-on-Crouch",
					Code = "BUU"
				},
				new Station
				{
					Name = "Burnley Barracks",
					Code = "BUB"
				},
				new Station
				{
					Name = "Burnley Central",
					Code = "BNC"
				},
				new Station
				{
					Name = "Burnley Manchester Road",
					Code = "BYM"
				},
				new Station
				{
					Name = "Burnside (Strathclyde)",
					Code = "BUI"
				},
				new Station
				{
					Name = "Burntisland",
					Code = "BTS"
				},
				new Station
				{
					Name = "Burscough Bridge",
					Code = "BCB"
				},
				new Station
				{
					Name = "Burscough Junction",
					Code = "BCJ"
				},
				new Station
				{
					Name = "Bursledon",
					Code = "BUO"
				},
				new Station
				{
					Name = "Burton Joyce",
					Code = "BUJ"
				},
				new Station
				{
					Name = "Burton-on-Trent",
					Code = "BUT"
				},
				new Station
				{
					Name = "Bury St Edmunds",
					Code = "BSE"
				},
				new Station
				{
					Name = "Busby",
					Code = "BUS"
				},
				new Station
				{
					Name = "Bush Hill Park",
					Code = "BHK"
				},
				new Station
				{
					Name = "Bushey",
					Code = "BSH"
				},
				new Station
				{
					Name = "Butlers Lane",
					Code = "BUL"
				},
				new Station
				{
					Name = "Buxted",
					Code = "BXD"
				},
				new Station
				{
					Name = "Buxton",
					Code = "BUX"
				},
				new Station
				{
					Name = "Byfleet & New Haw",
					Code = "BFN"
				},
				new Station
				{
					Name = "Bynea",
					Code = "BYE"
				},
				new Station
				{
					Name = "Cadoxton",
					Code = "CAD"
				},
				new Station
				{
					Name = "Caergwrle",
					Code = "CGW"
				},
				new Station
				{
					Name = "Caerphilly",
					Code = "CPH"
				},
				new Station
				{
					Name = "Caersws",
					Code = "CWS"
				},
				new Station
				{
					Name = "Caldercruix",
					Code = "CAC"
				},
				new Station
				{
					Name = "Caldicot",
					Code = "CDT"
				},
				new Station
				{
					Name = "Caledonian Rd & Barnsbury",
					Code = "CIR"
				},
				new Station
				{
					Name = "Calstock",
					Code = "CSK"
				},
				new Station
				{
					Name = "Cam & Dursley",
					Code = "CDU"
				},
				new Station
				{
					Name = "Camberley",
					Code = "CAM"
				},
				new Station
				{
					Name = "Camborne",
					Code = "CBN"
				},
				new Station
				{
					Name = "Cambridge",
					Code = "CBG"
				},
				new Station
				{
					Name = "Cambridge Heath",
					Code = "CBH"
				},
				new Station
				{
					Name = "Cambuslang",
					Code = "CBL"
				},
				new Station
				{
					Name = "Camden Road",
					Code = "CMD"
				},
				new Station
				{
					Name = "Camelon",
					Code = "CMO"
				},
				new Station
				{
					Name = "Canada Water",
					Code = "ZCW"
				},
				new Station
				{
					Name = "Canley",
					Code = "CNL"
				},
				new Station
				{
					Name = "Cannock",
					Code = "CAO"
				},
				new Station
				{
					Name = "Canonbury",
					Code = "CNN"
				},
				new Station
				{
					Name = "Canterbury East",
					Code = "CBE"
				},
				new Station
				{
					Name = "Canterbury West",
					Code = "CBW"
				},
				new Station
				{
					Name = "Cantley",
					Code = "CNY"
				},
				new Station
				{
					Name = "Capenhurst",
					Code = "CPU"
				},
				new Station
				{
					Name = "Carbis Bay",
					Code = "CBB"
				},
				new Station
				{
					Name = "Cardenden",
					Code = "CDD"
				},
				new Station
				{
					Name = "Cardiff Bay",
					Code = "CDB"
				},
				new Station
				{
					Name = "Cardiff Central",
					Code = "CDF"
				},
				new Station
				{
					Name = "Cardiff Queen Street",
					Code = "CDQ"
				},
				new Station
				{
					Name = "Cardonald",
					Code = "CDO"
				},
				new Station
				{
					Name = "Cardross",
					Code = "CDR"
				},
				new Station
				{
					Name = "Carfin",
					Code = "CRF"
				},
				new Station
				{
					Name = "Cark & Cartmel",
					Code = "CAK"
				},
				new Station
				{
					Name = "Carlisle",
					Code = "CAR"
				},
				new Station
				{
					Name = "Carlton",
					Code = "CTO"
				},
				new Station
				{
					Name = "Carluke",
					Code = "CLU"
				},
				new Station
				{
					Name = "Carmarthen",
					Code = "CMN"
				},
				new Station
				{
					Name = "Carmyle",
					Code = "CML"
				},
				new Station
				{
					Name = "Carnforth",
					Code = "CNF"
				},
				new Station
				{
					Name = "Carnoustie",
					Code = "CAN"
				},
				new Station
				{
					Name = "Carntyne",
					Code = "CAY"
				},
				new Station
				{
					Name = "Carpenders Park",
					Code = "CPK"
				},
				new Station
				{
					Name = "Carrbridge",
					Code = "CAG"
				},
				new Station
				{
					Name = "Carshalton",
					Code = "CSH"
				},
				new Station
				{
					Name = "Carshalton Beeches",
					Code = "CSB"
				},
				new Station
				{
					Name = "Carstairs",
					Code = "CRS"
				},
				new Station
				{
					Name = "Cartsdyke",
					Code = "CDY"
				},
				new Station
				{
					Name = "Castle Bar Park",
					Code = "CBP"
				},
				new Station
				{
					Name = "Castle Cary",
					Code = "CLC"
				},
				new Station
				{
					Name = "Castleford",
					Code = "CFD"
				},
				new Station
				{
					Name = "Castleton (Manchester)",
					Code = "CAS"
				},
				new Station
				{
					Name = "Castleton Moor",
					Code = "CSM"
				},
				new Station
				{
					Name = "Caterham",
					Code = "CAT"
				},
				new Station
				{
					Name = "Catford",
					Code = "CTF"
				},
				new Station
				{
					Name = "Catford Bridge",
					Code = "CFB"
				},
				new Station
				{
					Name = "Cathays",
					Code = "CYS"
				},
				new Station
				{
					Name = "Cathcart",
					Code = "CCT"
				},
				new Station
				{
					Name = "Cattal",
					Code = "CTL"
				},
				new Station
				{
					Name = "Causeland",
					Code = "CAU"
				},
				new Station
				{
					Name = "Cefn-y-Bedd",
					Code = "CYB"
				},
				new Station
				{
					Name = "Chadwell Heath",
					Code = "CTH"
				},
				new Station
				{
					Name = "Chafford Hundred Lakeside",
					Code = "CFH"
				},
				new Station
				{
					Name = "Chalfont & Latimer",
					Code = "CFO"
				},
				new Station
				{
					Name = "Chalkwell",
					Code = "CHW"
				},
				new Station
				{
					Name = "Chandlers Ford",
					Code = "CFR"
				},
				new Station
				{
					Name = "Chapel-en-le-Frith",
					Code = "CEF"
				},
				new Station
				{
					Name = "Chapelton (Devon)",
					Code = "CPN"
				},
				new Station
				{
					Name = "Chapeltown (South Yorks)",
					Code = "CLN"
				},
				new Station
				{
					Name = "Chappel & Wakes Colne",
					Code = "CWC"
				},
				new Station
				{
					Name = "Charing Cross (Glasgow)",
					Code = "CHC"
				},
				new Station
				{
					Name = "Charing (Kent)",
					Code = "CHG"
				},
				new Station
				{
					Name = "Charlbury",
					Code = "CBY"
				},
				new Station
				{
					Name = "Charlton",
					Code = "CTN"
				},
				new Station
				{
					Name = "Chartham",
					Code = "CRT"
				},
				new Station
				{
					Name = "Chassen Road",
					Code = "CSR"
				},
				new Station
				{
					Name = "Chatelherault",
					Code = "CTE"
				},
				new Station
				{
					Name = "Chatham",
					Code = "CTM"
				},
				new Station
				{
					Name = "Chathill",
					Code = "CHT"
				},
				new Station
				{
					Name = "Cheadle Hulme",
					Code = "CHU"
				},
				new Station
				{
					Name = "Cheam",
					Code = "CHE"
				},
				new Station
				{
					Name = "Cheddington",
					Code = "CED"
				},
				new Station
				{
					Name = "Chelford (Cheshire)",
					Code = "CEL"
				},
				new Station
				{
					Name = "Chelmsford",
					Code = "CHM"
				},
				new Station
				{
					Name = "Chelsfield",
					Code = "CLD"
				},
				new Station
				{
					Name = "Cheltenham Spa",
					Code = "CNM"
				},
				new Station
				{
					Name = "Chepstow",
					Code = "CPW"
				},
				new Station
				{
					Name = "Cherry Tree",
					Code = "CYT"
				},
				new Station
				{
					Name = "Chertsey",
					Code = "CHY"
				},
				new Station
				{
					Name = "Cheshunt",
					Code = "CHN"
				},
				new Station
				{
					Name = "Chessington North",
					Code = "CSN"
				},
				new Station
				{
					Name = "Chessington South",
					Code = "CSS"
				},
				new Station
				{
					Name = "Chester",
					Code = "CTR"
				},
				new Station
				{
					Name = "Chester Road",
					Code = "CRD"
				},
				new Station
				{
					Name = "Chesterfield",
					Code = "CHD"
				},
				new Station
				{
					Name = "Chester-le-Street",
					Code = "CLS"
				},
				new Station
				{
					Name = "Chestfield & Swalecliffe",
					Code = "CSW"
				},
				new Station
				{
					Name = "Chetnole",
					Code = "CNO"
				},
				new Station
				{
					Name = "Chichester",
					Code = "CCH"
				},
				new Station
				{
					Name = "Chilham",
					Code = "CIL"
				},
				new Station
				{
					Name = "Chilworth",
					Code = "CHL"
				},
				new Station
				{
					Name = "Chingford",
					Code = "CHI"
				},
				new Station
				{
					Name = "Chinley",
					Code = "CLY"
				},
				new Station
				{
					Name = "Chippenham",
					Code = "CPM"
				},
				new Station
				{
					Name = "Chipstead",
					Code = "CHP"
				},
				new Station
				{
					Name = "Chirk",
					Code = "CRK"
				},
				new Station
				{
					Name = "Chislehurst",
					Code = "CIT"
				},
				new Station
				{
					Name = "Chiswick",
					Code = "CHK"
				},
				new Station
				{
					Name = "Cholsey",
					Code = "CHO"
				},
				new Station
				{
					Name = "Chorley",
					Code = "CRL"
				},
				new Station
				{
					Name = "Chorleywood",
					Code = "CLW"
				},
				new Station
				{
					Name = "Christchurch",
					Code = "CHR"
				},
				new Station
				{
					Name = "Christ's Hospital",
					Code = "CHH"
				},
				new Station
				{
					Name = "Church & Oswaldtwistle",
					Code = "CTW"
				},
				new Station
				{
					Name = "Church Fenton",
					Code = "CHF"
				},
				new Station
				{
					Name = "Church Stretton",
					Code = "CTT"
				},
				new Station
				{
					Name = "Cilmeri",
					Code = "CIM"
				},
				new Station
				{
					Name = "City Thameslink",
					Code = "CTK"
				},
				new Station
				{
					Name = "Clacton-on-Sea",
					Code = "CLT"
				},
				new Station
				{
					Name = "Clandon",
					Code = "CLA"
				},
				new Station
				{
					Name = "Clapham High Street",
					Code = "CLP"
				},
				new Station
				{
					Name = "Clapham Junction",
					Code = "CLJ"
				},
				new Station
				{
					Name = "Clapham (North Yorkshire)",
					Code = "CPY"
				},
				new Station
				{
					Name = "Clapton",
					Code = "CPT"
				},
				new Station
				{
					Name = "Clarbeston Road",
					Code = "CLR"
				},
				new Station
				{
					Name = "Clarkston",
					Code = "CKS"
				},
				new Station
				{
					Name = "Claverdon",
					Code = "CLV"
				},
				new Station
				{
					Name = "Claygate",
					Code = "CLG"
				},
				new Station
				{
					Name = "Cleethorpes",
					Code = "CLE"
				},
				new Station
				{
					Name = "Cleland",
					Code = "CEA"
				},
				new Station
				{
					Name = "Clifton Down",
					Code = "CFN"
				},
				new Station
				{
					Name = "Clifton (Manchester)",
					Code = "CLI"
				},
				new Station
				{
					Name = "Clitheroe",
					Code = "CLH"
				},
				new Station
				{
					Name = "Clock House",
					Code = "CLK"
				},
				new Station
				{
					Name = "Clunderwen",
					Code = "CUW"
				},
				new Station
				{
					Name = "Clydebank",
					Code = "CYK"
				},
				new Station
				{
					Name = "Coatbridge Central",
					Code = "CBC"
				},
				new Station
				{
					Name = "Coatbridge Sunnyside",
					Code = "CBS"
				},
				new Station
				{
					Name = "Coatdyke",
					Code = "COA"
				},
				new Station
				{
					Name = "Cobham & Stoke d'Abernon",
					Code = "CSD"
				},
				new Station
				{
					Name = "Codsall",
					Code = "CSL"
				},
				new Station
				{
					Name = "Cogan",
					Code = "CGN"
				},
				new Station
				{
					Name = "Colchester",
					Code = "COL"
				},
				new Station
				{
					Name = "Colchester Town",
					Code = "CET"
				},
				new Station
				{
					Name = "Coleshill Parkway",
					Code = "CEH"
				},
				new Station
				{
					Name = "Collingham",
					Code = "CLM"
				},
				new Station
				{
					Name = "Collington",
					Code = "CLL"
				},
				new Station
				{
					Name = "Colne",
					Code = "CNE"
				},
				new Station
				{
					Name = "Colwall",
					Code = "CWL"
				},
				new Station
				{
					Name = "Colwyn Bay",
					Code = "CWB"
				},
				new Station
				{
					Name = "Combe (Oxon)",
					Code = "CME"
				},
				new Station
				{
					Name = "Commondale",
					Code = "COM"
				},
				new Station
				{
					Name = "Congleton",
					Code = "CNG"
				},
				new Station
				{
					Name = "Conisbrough",
					Code = "CNS"
				},
				new Station
				{
					Name = "Connel Ferry",
					Code = "CON"
				},
				new Station
				{
					Name = "Conon Bridge",
					Code = "CBD"
				},
				new Station
				{
					Name = "Cononley",
					Code = "CEY"
				},
				new Station
				{
					Name = "Conway Park",
					Code = "CNP"
				},
				new Station
				{
					Name = "Conwy",
					Code = "CNW"
				},
				new Station
				{
					Name = "Cooden Beach",
					Code = "COB"
				},
				new Station
				{
					Name = "Cookham",
					Code = "COO"
				},
				new Station
				{
					Name = "Cooksbridge",
					Code = "CBR"
				},
				new Station
				{
					Name = "Coombe Junction Halt",
					Code = "COE"
				},
				new Station
				{
					Name = "Copplestone",
					Code = "COP"
				},
				new Station
				{
					Name = "Corbridge",
					Code = "CRB"
				},
				new Station
				{
					Name = "Corby",
					Code = "COR"
				},
				new Station
				{
					Name = "Corkerhill",
					Code = "CKH"
				},
				new Station
				{
					Name = "Corkickle",
					Code = "CKL"
				},
				new Station
				{
					Name = "Corpach",
					Code = "CPA"
				},
				new Station
				{
					Name = "Corrour",
					Code = "CRR"
				},
				new Station
				{
					Name = "Coryton",
					Code = "COY"
				},
				new Station
				{
					Name = "Coseley",
					Code = "CSY"
				},
				new Station
				{
					Name = "Cosford",
					Code = "COS"
				},
				new Station
				{
					Name = "Cosham",
					Code = "CSA"
				},
				new Station
				{
					Name = "Cottingham",
					Code = "CGM"
				},
				new Station
				{
					Name = "Cottingley",
					Code = "COT"
				},
				new Station
				{
					Name = "Coulsdon South",
					Code = "CDS"
				},
				new Station
				{
					Name = "Coulsdon Town",
					Code = "CDN"
				},
				new Station
				{
					Name = "Coventry",
					Code = "COV"
				},
				new Station
				{
					Name = "Cowden (Kent)",
					Code = "CWN"
				},
				new Station
				{
					Name = "Cowdenbeath",
					Code = "COW"
				},
				new Station
				{
					Name = "Cradley Heath",
					Code = "CRA"
				},
				new Station
				{
					Name = "Craigendoran",
					Code = "CGD"
				},
				new Station
				{
					Name = "Cramlington",
					Code = "CRM"
				},
				new Station
				{
					Name = "Cranbrook",
					Code = "CBK"
				},
				new Station
				{
					Name = "Craven Arms",
					Code = "CRV"
				},
				new Station
				{
					Name = "Crawley",
					Code = "CRW"
				},
				new Station
				{
					Name = "Crayford",
					Code = "CRY"
				},
				new Station
				{
					Name = "Crediton",
					Code = "CDI"
				},
				new Station
				{
					Name = "Cressing (Essex)",
					Code = "CES"
				},
				new Station
				{
					Name = "Cressington",
					Code = "CSG"
				},
				new Station
				{
					Name = "Creswell",
					Code = "CWD"
				},
				new Station
				{
					Name = "Crewe",
					Code = "CRE"
				},
				new Station
				{
					Name = "Crewkerne",
					Code = "CKN"
				},
				new Station
				{
					Name = "Crews Hill",
					Code = "CWH"
				},
				new Station
				{
					Name = "Crianlarich",
					Code = "CNR"
				},
				new Station
				{
					Name = "Criccieth",
					Code = "CCC"
				},
				new Station
				{
					Name = "Cricklewood",
					Code = "CRI"
				},
				new Station
				{
					Name = "Croftfoot",
					Code = "CFF"
				},
				new Station
				{
					Name = "Crofton Park",
					Code = "CFT"
				},
				new Station
				{
					Name = "Cromer",
					Code = "CMR"
				},
				new Station
				{
					Name = "Cromford",
					Code = "CMF"
				},
				new Station
				{
					Name = "Crookston",
					Code = "CKT"
				},
				new Station
				{
					Name = "Cross Gates",
					Code = "CRG"
				},
				new Station
				{
					Name = "Crossflatts",
					Code = "CFL"
				},
				new Station
				{
					Name = "Crosshill",
					Code = "COI"
				},
				new Station
				{
					Name = "Crosskeys",
					Code = "CKY"
				},
				new Station
				{
					Name = "Crossmyloof",
					Code = "CMY"
				},
				new Station
				{
					Name = "Croston",
					Code = "CSO"
				},
				new Station
				{
					Name = "Crouch Hill",
					Code = "CRH"
				},
				new Station
				{
					Name = "Crowborough",
					Code = "COH"
				},
				new Station
				{
					Name = "Crowhurst",
					Code = "CWU"
				},
				new Station
				{
					Name = "Crowle",
					Code = "CWE"
				},
				new Station
				{
					Name = "Crowthorne",
					Code = "CRN"
				},
				new Station
				{
					Name = "Croy",
					Code = "CRO"
				},
				new Station
				{
					Name = "Crystal Palace",
					Code = "CYP"
				},
				new Station
				{
					Name = "Cuddington",
					Code = "CUD"
				},
				new Station
				{
					Name = "Cuffley",
					Code = "CUF"
				},
				new Station
				{
					Name = "Culham",
					Code = "CUM"
				},
				new Station
				{
					Name = "Culrain",
					Code = "CUA"
				},
				new Station
				{
					Name = "Cumbernauld",
					Code = "CUB"
				},
				new Station
				{
					Name = "Cupar",
					Code = "CUP"
				},
				new Station
				{
					Name = "Curriehill",
					Code = "CUH"
				},
				new Station
				{
					Name = "Cuxton",
					Code = "CUX"
				},
				new Station
				{
					Name = "Cwmbach",
					Code = "CMH"
				},
				new Station
				{
					Name = "Cwmbran",
					Code = "CWM"
				},
				new Station
				{
					Name = "Cynghordy",
					Code = "CYN"
				},
				new Station
				{
					Name = "Dagenham Dock",
					Code = "DDK"
				},
				new Station
				{
					Name = "Daisy Hill",
					Code = "DSY"
				},
				new Station
				{
					Name = "Dalgety Bay",
					Code = "DAG"
				},
				new Station
				{
					Name = "Dalmally",
					Code = "DAL"
				},
				new Station
				{
					Name = "Dalmarnock",
					Code = "DAK"
				},
				new Station
				{
					Name = "Dalmeny",
					Code = "DAM"
				},
				new Station
				{
					Name = "Dalmuir",
					Code = "DMR"
				},
				new Station
				{
					Name = "Dalreoch",
					Code = "DLR"
				},
				new Station
				{
					Name = "Dalry",
					Code = "DLY"
				},
				new Station
				{
					Name = "Dalston (Cumbria)",
					Code = "DLS"
				},
				new Station
				{
					Name = "Dalston Junction",
					Code = "DLJ"
				},
				new Station
				{
					Name = "Dalston Kingsland",
					Code = "DLK"
				},
				new Station
				{
					Name = "Dalton (Cumbria)",
					Code = "DLT"
				},
				new Station
				{
					Name = "Dalwhinnie",
					Code = "DLW"
				},
				new Station
				{
					Name = "Danby",
					Code = "DNY"
				},
				new Station
				{
					Name = "Danescourt",
					Code = "DCT"
				},
				new Station
				{
					Name = "Danzey",
					Code = "DZY"
				},
				new Station
				{
					Name = "Darlington",
					Code = "DAR"
				},
				new Station
				{
					Name = "Darnall",
					Code = "DAN"
				},
				new Station
				{
					Name = "Darsham",
					Code = "DSM"
				},
				new Station
				{
					Name = "Dartford",
					Code = "DFD"
				},
				new Station
				{
					Name = "Darton",
					Code = "DRT"
				},
				new Station
				{
					Name = "Darwen",
					Code = "DWN"
				},
				new Station
				{
					Name = "Datchet",
					Code = "DAT"
				},
				new Station
				{
					Name = "Davenport",
					Code = "DVN"
				},
				new Station
				{
					Name = "Dawlish",
					Code = "DWL"
				},
				new Station
				{
					Name = "Dawlish Warren",
					Code = "DWW"
				},
				new Station
				{
					Name = "Deal",
					Code = "DEA"
				},
				new Station
				{
					Name = "Dean (Wilts)",
					Code = "DEN"
				},
				new Station
				{
					Name = "Deansgate",
					Code = "DGT"
				},
				new Station
				{
					Name = "Deganwy",
					Code = "DGY"
				},
				new Station
				{
					Name = "Deighton",
					Code = "DHN"
				},
				new Station
				{
					Name = "Delamere",
					Code = "DLM"
				},
				new Station
				{
					Name = "Denby Dale",
					Code = "DBD"
				},
				new Station
				{
					Name = "Denham",
					Code = "DNM"
				},
				new Station
				{
					Name = "Denham Golf Club",
					Code = "DGC"
				},
				new Station
				{
					Name = "Denmark Hill",
					Code = "DMK"
				},
				new Station
				{
					Name = "Dent",
					Code = "DNT"
				},
				new Station
				{
					Name = "Denton",
					Code = "DTN"
				},
				new Station
				{
					Name = "Deptford",
					Code = "DEP"
				},
				new Station
				{
					Name = "Derby",
					Code = "DBY"
				},
				new Station
				{
					Name = "Derby Road (Ipswich)",
					Code = "DBR"
				},
				new Station
				{
					Name = "Devonport (Devon)",
					Code = "DPT"
				},
				new Station
				{
					Name = "Devonport Dockyard",
					Code = "DOC"
				},
				new Station
				{
					Name = "Dewsbury",
					Code = "DEW"
				},
				new Station
				{
					Name = "Didcot Parkway",
					Code = "DID"
				},
				new Station
				{
					Name = "Digby & Sowton",
					Code = "DIG"
				},
				new Station
				{
					Name = "Dilton Marsh",
					Code = "DMH"
				},
				new Station
				{
					Name = "Dinas Powys",
					Code = "DNS"
				},
				new Station
				{
					Name = "Dinas (Rhondda)",
					Code = "DMG"
				},
				new Station
				{
					Name = "Dingle Road",
					Code = "DGL"
				},
				new Station
				{
					Name = "Dingwall",
					Code = "DIN"
				},
				new Station
				{
					Name = "Dinsdale",
					Code = "DND"
				},
				new Station
				{
					Name = "Dinting",
					Code = "DTG"
				},
				new Station
				{
					Name = "Disley",
					Code = "DSL"
				},
				new Station
				{
					Name = "Diss",
					Code = "DIS"
				},
				new Station
				{
					Name = "Dodworth",
					Code = "DOD"
				},
				new Station
				{
					Name = "Dolau",
					Code = "DOL"
				},
				new Station
				{
					Name = "Doleham",
					Code = "DLH"
				},
				new Station
				{
					Name = "Dolgarrog",
					Code = "DLG"
				},
				new Station
				{
					Name = "Dolwyddelan",
					Code = "DWD"
				},
				new Station
				{
					Name = "Doncaster",
					Code = "DON"
				},
				new Station
				{
					Name = "Dorchester South",
					Code = "DCH"
				},
				new Station
				{
					Name = "Dorchester West",
					Code = "DCW"
				},
				new Station
				{
					Name = "Dore & Totley",
					Code = "DOR"
				},
				new Station
				{
					Name = "Dorking Deepdene",
					Code = "DPD"
				},
				new Station
				{
					Name = "Dorking (Main)",
					Code = "DKG"
				},
				new Station
				{
					Name = "Dorking West",
					Code = "DKT"
				},
				new Station
				{
					Name = "Dormans",
					Code = "DMS"
				},
				new Station
				{
					Name = "Dorridge",
					Code = "DDG"
				},
				new Station
				{
					Name = "Dove Holes",
					Code = "DVH"
				},
				new Station
				{
					Name = "Dover Priory",
					Code = "DVP"
				},
				new Station
				{
					Name = "Dovercourt",
					Code = "DVC"
				},
				new Station
				{
					Name = "Dovey Junction",
					Code = "DVY"
				},
				new Station
				{
					Name = "Downham Market",
					Code = "DOW"
				},
				new Station
				{
					Name = "Drayton Green",
					Code = "DRG"
				},
				new Station
				{
					Name = "Drayton Park",
					Code = "DYP"
				},
				new Station
				{
					Name = "Drem",
					Code = "DRM"
				},
				new Station
				{
					Name = "Driffield",
					Code = "DRF"
				},
				new Station
				{
					Name = "Drigg",
					Code = "DRI"
				},
				new Station
				{
					Name = "Droitwich Spa",
					Code = "DTW"
				},
				new Station
				{
					Name = "Dronfield",
					Code = "DRO"
				},
				new Station
				{
					Name = "Drumchapel",
					Code = "DMC"
				},
				new Station
				{
					Name = "Drumfrochar",
					Code = "DFR"
				},
				new Station
				{
					Name = "Drumgelloch",
					Code = "DRU"
				},
				new Station
				{
					Name = "Drumry",
					Code = "DMY"
				},
				new Station
				{
					Name = "Dublin Ferryport",
					Code = "DFP"
				},
				new Station
				{
					Name = "Dublin Port - Stena",
					Code = "DPS"
				},
				new Station
				{
					Name = "Duddeston",
					Code = "DUD"
				},
				new Station
				{
					Name = "Dudley Port",
					Code = "DDP"
				},
				new Station
				{
					Name = "Duffield",
					Code = "DFI"
				},
				new Station
				{
					Name = "Duirinish",
					Code = "DRN"
				},
				new Station
				{
					Name = "Duke Street",
					Code = "DST"
				},
				new Station
				{
					Name = "Dullingham",
					Code = "DUL"
				},
				new Station
				{
					Name = "Dumbarton Central",
					Code = "DBC"
				},
				new Station
				{
					Name = "Dumbarton East",
					Code = "DBE"
				},
				new Station
				{
					Name = "Dumbreck",
					Code = "DUM"
				},
				new Station
				{
					Name = "Dumfries",
					Code = "DMF"
				},
				new Station
				{
					Name = "Dumpton Park",
					Code = "DMP"
				},
				new Station
				{
					Name = "Dunbar",
					Code = "DUN"
				},
				new Station
				{
					Name = "Dunblane",
					Code = "DBL"
				},
				new Station
				{
					Name = "Duncraig",
					Code = "DCG"
				},
				new Station
				{
					Name = "Dundee",
					Code = "DEE"
				},
				new Station
				{
					Name = "Dunfermline Queen Margaret",
					Code = "DFL"
				},
				new Station
				{
					Name = "Dunfermline Town",
					Code = "DFE"
				},
				new Station
				{
					Name = "Dunkeld & Birnam",
					Code = "DKD"
				},
				new Station
				{
					Name = "Dunlop",
					Code = "DNL"
				},
				new Station
				{
					Name = "Dunrobin Castle",
					Code = "DNO"
				},
				new Station
				{
					Name = "Dunston",
					Code = "DOT"
				},
				new Station
				{
					Name = "Dunton Green",
					Code = "DNG"
				},
				new Station
				{
					Name = "Durham",
					Code = "DHM"
				},
				new Station
				{
					Name = "Durrington-on-Sea",
					Code = "DUR"
				},
				new Station
				{
					Name = "Dyce",
					Code = "DYC"
				},
				new Station
				{
					Name = "Dyffryn Ardudwy",
					Code = "DYF"
				},
				new Station
				{
					Name = "Eaglescliffe",
					Code = "EAG"
				},
				new Station
				{
					Name = "Ealing Broadway",
					Code = "EAL"
				},
				new Station
				{
					Name = "Earlestown",
					Code = "ERL"
				},
				new Station
				{
					Name = "Earley",
					Code = "EAR"
				},
				new Station
				{
					Name = "Earlsfield",
					Code = "EAD"
				},
				new Station
				{
					Name = "Earlswood (Surrey)",
					Code = "ELD"
				},
				new Station
				{
					Name = "Earlswood (West Midlands)",
					Code = "EWD"
				},
				new Station
				{
					Name = "East Croydon",
					Code = "ECR"
				},
				new Station
				{
					Name = "East Didsbury",
					Code = "EDY"
				},
				new Station
				{
					Name = "East Dulwich",
					Code = "EDW"
				},
				new Station
				{
					Name = "East Farleigh",
					Code = "EFL"
				},
				new Station
				{
					Name = "East Garforth",
					Code = "EGF"
				},
				new Station
				{
					Name = "East Grinstead",
					Code = "EGR"
				},
				new Station
				{
					Name = "East Kilbride",
					Code = "EKL"
				},
				new Station
				{
					Name = "East Malling",
					Code = "EML"
				},
				new Station
				{
					Name = "East Midlands Parkway",
					Code = "EMD"
				},
				new Station
				{
					Name = "East Tilbury",
					Code = "ETL"
				},
				new Station
				{
					Name = "East Worthing",
					Code = "EWR"
				},
				new Station
				{
					Name = "Eastbourne",
					Code = "EBN"
				},
				new Station
				{
					Name = "Eastbrook",
					Code = "EBK"
				},
				new Station
				{
					Name = "Easterhouse",
					Code = "EST"
				},
				new Station
				{
					Name = "Eastham Rake",
					Code = "ERA"
				},
				new Station
				{
					Name = "Eastleigh",
					Code = "ESL"
				},
				new Station
				{
					Name = "Eastrington",
					Code = "EGN"
				},
				new Station
				{
					Name = "Ebbsfleet International",
					Code = "EBD"
				},
				new Station
				{
					Name = "Ebbw Vale Parkway",
					Code = "EBV"
				},
				new Station
				{
					Name = "Eccles (Manchester)",
					Code = "ECC"
				},
				new Station
				{
					Name = "Eccles Road",
					Code = "ECS"
				},
				new Station
				{
					Name = "Eccleston Park",
					Code = "ECL"
				},
				new Station
				{
					Name = "Edale",
					Code = "EDL"
				},
				new Station
				{
					Name = "Eden Park",
					Code = "EDN"
				},
				new Station
				{
					Name = "Edenbridge (Kent)",
					Code = "EBR"
				},
				new Station
				{
					Name = "Edenbridge Town",
					Code = "EBT"
				},
				new Station
				{
					Name = "Edge Hill",
					Code = "EDG"
				},
				new Station
				{
					Name = "Edinburgh",
					Code = "EDB"
				},
				new Station
				{
					Name = "Edinburgh Park",
					Code = "EDP"
				},
				new Station
				{
					Name = "Edmonton Green",
					Code = "EDR"
				},
				new Station
				{
					Name = "Effingham Junction",
					Code = "EFF"
				},
				new Station
				{
					Name = "Eggesford",
					Code = "EGG"
				},
				new Station
				{
					Name = "Egham",
					Code = "EGH"
				},
				new Station
				{
					Name = "Egton",
					Code = "EGT"
				},
				new Station
				{
					Name = "Elephant & Castle",
					Code = "EPH"
				},
				new Station
				{
					Name = "Elephant & Castle (Underground)",
					Code = "ZEL"
				},
				new Station
				{
					Name = "Elgin",
					Code = "ELG"
				},
				new Station
				{
					Name = "Ellesmere Port",
					Code = "ELP"
				},
				new Station
				{
					Name = "Elmers End",
					Code = "ELE"
				},
				new Station
				{
					Name = "Elmstead Woods",
					Code = "ESD"
				},
				new Station
				{
					Name = "Elmswell",
					Code = "ESW"
				},
				new Station
				{
					Name = "Elsecar",
					Code = "ELR"
				},
				new Station
				{
					Name = "Elsenham (Essex)",
					Code = "ESM"
				},
				new Station
				{
					Name = "Elstree & Borehamwood",
					Code = "ELS"
				},
				new Station
				{
					Name = "Eltham",
					Code = "ELW"
				},
				new Station
				{
					Name = "Elton & Orston",
					Code = "ELO"
				},
				new Station
				{
					Name = "Ely",
					Code = "ELY"
				},
				new Station
				{
					Name = "Emerson Park",
					Code = "EMP"
				},
				new Station
				{
					Name = "Emsworth",
					Code = "EMS"
				},
				new Station
				{
					Name = "Enfield Chase",
					Code = "ENC"
				},
				new Station
				{
					Name = "Enfield Lock",
					Code = "ENL"
				},
				new Station
				{
					Name = "Enfield Town",
					Code = "ENF"
				},
				new Station
				{
					Name = "Entwistle",
					Code = "ENT"
				},
				new Station
				{
					Name = "Epsom Downs",
					Code = "EPD"
				},
				new Station
				{
					Name = "Epsom (Surrey)",
					Code = "EPS"
				},
				new Station
				{
					Name = "Erdington",
					Code = "ERD"
				},
				new Station
				{
					Name = "Eridge",
					Code = "ERI"
				},
				new Station
				{
					Name = "Erith",
					Code = "ERH"
				},
				new Station
				{
					Name = "Esher",
					Code = "ESH"
				},
				new Station
				{
					Name = "Essex Road",
					Code = "EXR"
				},
				new Station
				{
					Name = "Etchingham",
					Code = "ETC"
				},
				new Station
				{
					Name = "Euxton Balshaw Lane",
					Code = "EBA"
				},
				new Station
				{
					Name = "Evesham",
					Code = "EVE"
				},
				new Station
				{
					Name = "Ewell East",
					Code = "EWE"
				},
				new Station
				{
					Name = "Ewell West",
					Code = "EWW"
				},
				new Station
				{
					Name = "Exeter Central",
					Code = "EXC"
				},
				new Station
				{
					Name = "Exeter St David's",
					Code = "EXD"
				},
				new Station
				{
					Name = "Exeter St Thomas",
					Code = "EXT"
				},
				new Station
				{
					Name = "Exhibition Centre (Glasgow)",
					Code = "EXG"
				},
				new Station
				{
					Name = "Exmouth",
					Code = "EXM"
				},
				new Station
				{
					Name = "Exton",
					Code = "EXN"
				},
				new Station
				{
					Name = "Eynsford",
					Code = "EYN"
				},
				new Station
				{
					Name = "Fairbourne",
					Code = "FRB"
				},
				new Station
				{
					Name = "Fairfield",
					Code = "FRF"
				},
				new Station
				{
					Name = "Fairlie",
					Code = "FRL"
				},
				new Station
				{
					Name = "Fairwater",
					Code = "FRW"
				},
				new Station
				{
					Name = "Falconwood",
					Code = "FCN"
				},
				new Station
				{
					Name = "Falkirk Grahamston",
					Code = "FKG"
				},
				new Station
				{
					Name = "Falkirk High",
					Code = "FKK"
				},
				new Station
				{
					Name = "Falls of Cruachan",
					Code = "FOC"
				},
				new Station
				{
					Name = "Falmer",
					Code = "FMR"
				},
				new Station
				{
					Name = "Falmouth Docks",
					Code = "FAL"
				},
				new Station
				{
					Name = "Falmouth Town",
					Code = "FMT"
				},
				new Station
				{
					Name = "Fareham",
					Code = "FRM"
				},
				new Station
				{
					Name = "Farnborough (Main)",
					Code = "FNB"
				},
				new Station
				{
					Name = "Farnborough North",
					Code = "FNN"
				},
				new Station
				{
					Name = "Farncombe",
					Code = "FNC"
				},
				new Station
				{
					Name = "Farnham",
					Code = "FNH"
				},
				new Station
				{
					Name = "Farningham Road",
					Code = "FNR"
				},
				new Station
				{
					Name = "Farnworth",
					Code = "FNW"
				},
				new Station
				{
					Name = "Farringdon",
					Code = "ZFD"
				},
				new Station
				{
					Name = "Fauldhouse",
					Code = "FLD"
				},
				new Station
				{
					Name = "Faversham",
					Code = "FAV"
				},
				new Station
				{
					Name = "Faygate",
					Code = "FGT"
				},
				new Station
				{
					Name = "Fazakerley",
					Code = "FAZ"
				},
				new Station
				{
					Name = "Fearn",
					Code = "FRN"
				},
				new Station
				{
					Name = "Featherstone",
					Code = "FEA"
				},
				new Station
				{
					Name = "Felixstowe",
					Code = "FLX"
				},
				new Station
				{
					Name = "Feltham",
					Code = "FEL"
				},
				new Station
				{
					Name = "Feniton",
					Code = "FNT"
				},
				new Station
				{
					Name = "Fenny Stratford",
					Code = "FEN"
				},
				new Station
				{
					Name = "Fernhill",
					Code = "FER"
				},
				new Station
				{
					Name = "Ferriby",
					Code = "FRY"
				},
				new Station
				{
					Name = "Ferryside",
					Code = "FYS"
				},
				new Station
				{
					Name = "Ffairfach",
					Code = "FFA"
				},
				new Station
				{
					Name = "Filey",
					Code = "FIL"
				},
				new Station
				{
					Name = "Filton Abbey Wood",
					Code = "FIT"
				},
				new Station
				{
					Name = "Finchley Road & Frognal",
					Code = "FNY"
				},
				new Station
				{
					Name = "Finsbury Park",
					Code = "FPK"
				},
				new Station
				{
					Name = "Finstock",
					Code = "FIN"
				},
				new Station
				{
					Name = "Fishbourne (Sussex)",
					Code = "FSB"
				},
				new Station
				{
					Name = "Fishersgate",
					Code = "FSG"
				},
				new Station
				{
					Name = "Fishguard & Goodwick",
					Code = "FGW"
				},
				new Station
				{
					Name = "Fishguard Harbour",
					Code = "FGH"
				},
				new Station
				{
					Name = "Fiskerton",
					Code = "FSK"
				},
				new Station
				{
					Name = "Fitzwilliam",
					Code = "FZW"
				},
				new Station
				{
					Name = "Five Ways",
					Code = "FWY"
				},
				new Station
				{
					Name = "Fleet",
					Code = "FLE"
				},
				new Station
				{
					Name = "Flimby",
					Code = "FLM"
				},
				new Station
				{
					Name = "Flint",
					Code = "FLN"
				},
				new Station
				{
					Name = "Flitwick",
					Code = "FLT"
				},
				new Station
				{
					Name = "Flixton",
					Code = "FLI"
				},
				new Station
				{
					Name = "Flowery Field",
					Code = "FLF"
				},
				new Station
				{
					Name = "Folkestone Central",
					Code = "FKC"
				},
				new Station
				{
					Name = "Folkestone West",
					Code = "FKW"
				},
				new Station
				{
					Name = "Ford",
					Code = "FOD"
				},
				new Station
				{
					Name = "Forest Gate",
					Code = "FOG"
				},
				new Station
				{
					Name = "Forest Hill",
					Code = "FOH"
				},
				new Station
				{
					Name = "Formby",
					Code = "FBY"
				},
				new Station
				{
					Name = "Forres",
					Code = "FOR"
				},
				new Station
				{
					Name = "Forsinard",
					Code = "FRS"
				},
				new Station
				{
					Name = "Fort Matilda",
					Code = "FTM"
				},
				new Station
				{
					Name = "Fort William",
					Code = "FTW"
				},
				new Station
				{
					Name = "Four Oaks",
					Code = "FOK"
				},
				new Station
				{
					Name = "Foxfield",
					Code = "FOX"
				},
				new Station
				{
					Name = "Foxton",
					Code = "FXN"
				},
				new Station
				{
					Name = "Frant",
					Code = "FRT"
				},
				new Station
				{
					Name = "Fratton",
					Code = "FTN"
				},
				new Station
				{
					Name = "Freshfield",
					Code = "FRE"
				},
				new Station
				{
					Name = "Freshford",
					Code = "FFD"
				},
				new Station
				{
					Name = "Frimley",
					Code = "FML"
				},
				new Station
				{
					Name = "Frinton-on-Sea",
					Code = "FRI"
				},
				new Station
				{
					Name = "Frizinghall",
					Code = "FZH"
				},
				new Station
				{
					Name = "Frodsham",
					Code = "FRD"
				},
				new Station
				{
					Name = "Frome",
					Code = "FRO"
				},
				new Station
				{
					Name = "Fulwell",
					Code = "FLW"
				},
				new Station
				{
					Name = "Furness Vale",
					Code = "FNV"
				},
				new Station
				{
					Name = "Furze Platt",
					Code = "FZP"
				},
				new Station
				{
					Name = "Gainsborough Central",
					Code = "GNB"
				},
				new Station
				{
					Name = "Gainsborough Lea Road",
					Code = "GBL"
				},
				new Station
				{
					Name = "Garelochhead",
					Code = "GCH"
				},
				new Station
				{
					Name = "Garforth",
					Code = "GRF"
				},
				new Station
				{
					Name = "Gargrave",
					Code = "GGV"
				},
				new Station
				{
					Name = "Garrowhill",
					Code = "GAR"
				},
				new Station
				{
					Name = "Garscadden",
					Code = "GRS"
				},
				new Station
				{
					Name = "Garsdale",
					Code = "GSD"
				},
				new Station
				{
					Name = "Garston (Hertfordshire)",
					Code = "GSN"
				},
				new Station
				{
					Name = "Garswood",
					Code = "GSW"
				},
				new Station
				{
					Name = "Gartcosh",
					Code = "GRH"
				},
				new Station
				{
					Name = "Garth (Bridgend)",
					Code = "GMG"
				},
				new Station
				{
					Name = "Garth (Powys)",
					Code = "GTH"
				},
				new Station
				{
					Name = "Garve",
					Code = "GVE"
				},
				new Station
				{
					Name = "Gathurst",
					Code = "GST"
				},
				new Station
				{
					Name = "Gatley",
					Code = "GTY"
				},
				new Station
				{
					Name = "Gatwick Airport",
					Code = "GTW"
				},
				new Station
				{
					Name = "Georgemas Junction",
					Code = "GGJ"
				},
				new Station
				{
					Name = "Gerrards Cross",
					Code = "GER"
				},
				new Station
				{
					Name = "Gidea Park",
					Code = "GDP"
				},
				new Station
				{
					Name = "Giffnock",
					Code = "GFN"
				},
				new Station
				{
					Name = "Giggleswick",
					Code = "GIG"
				},
				new Station
				{
					Name = "Gilberdyke",
					Code = "GBD"
				},
				new Station
				{
					Name = "Gilfach Fargoed",
					Code = "GFF"
				},
				new Station
				{
					Name = "Gillingham (Dorset)",
					Code = "GIL"
				},
				new Station
				{
					Name = "Gillingham (Kent)",
					Code = "GLM"
				},
				new Station
				{
					Name = "Gilshochill",
					Code = "GSC"
				},
				new Station
				{
					Name = "Gipsy Hill",
					Code = "GIP"
				},
				new Station
				{
					Name = "Girvan",
					Code = "GIR"
				},
				new Station
				{
					Name = "Glaisdale",
					Code = "GLS"
				},
				new Station
				{
					Name = "Glan Conwy",
					Code = "GCW"
				},
				new Station
				{
					Name = "Glasgow Central",
					Code = "GLC"
				},
				new Station
				{
					Name = "Glasgow Queen Street",
					Code = "GLQ"
				},
				new Station
				{
					Name = "Glasshoughton",
					Code = "GLH"
				},
				new Station
				{
					Name = "Glazebrook",
					Code = "GLZ"
				},
				new Station
				{
					Name = "Gleneagles",
					Code = "GLE"
				},
				new Station
				{
					Name = "Glenfinnan",
					Code = "GLF"
				},
				new Station
				{
					Name = "Glengarnock",
					Code = "GLG"
				},
				new Station
				{
					Name = "Glenrothes with Thornton",
					Code = "GLT"
				},
				new Station
				{
					Name = "Glossop",
					Code = "GLO"
				},
				new Station
				{
					Name = "Gloucester",
					Code = "GCR"
				},
				new Station
				{
					Name = "Glynde",
					Code = "GLY"
				},
				new Station
				{
					Name = "Gobowen",
					Code = "GOB"
				},
				new Station
				{
					Name = "Godalming",
					Code = "GOD"
				},
				new Station
				{
					Name = "Godley",
					Code = "GDL"
				},
				new Station
				{
					Name = "Godstone",
					Code = "GDN"
				},
				new Station
				{
					Name = "Goldthorpe",
					Code = "GOE"
				},
				new Station
				{
					Name = "Golf Street",
					Code = "GOF"
				},
				new Station
				{
					Name = "Golspie",
					Code = "GOL"
				},
				new Station
				{
					Name = "Gomshall",
					Code = "GOM"
				},
				new Station
				{
					Name = "Goodmayes",
					Code = "GMY"
				},
				new Station
				{
					Name = "Goole",
					Code = "GOO"
				},
				new Station
				{
					Name = "Goostrey",
					Code = "GTR"
				},
				new Station
				{
					Name = "Gordon Hill",
					Code = "GDH"
				},
				new Station
				{
					Name = "Goring & Streatley",
					Code = "GOR"
				},
				new Station
				{
					Name = "Goring-by-Sea",
					Code = "GBS"
				},
				new Station
				{
					Name = "Gorton",
					Code = "GTO"
				},
				new Station
				{
					Name = "Gospel Oak",
					Code = "GPO"
				},
				new Station
				{
					Name = "Gourock",
					Code = "GRK"
				},
				new Station
				{
					Name = "Gowerton",
					Code = "GWN"
				},
				new Station
				{
					Name = "Goxhill",
					Code = "GOX"
				},
				new Station
				{
					Name = "Grange Park",
					Code = "GPK"
				},
				new Station
				{
					Name = "Grange-Over-Sands",
					Code = "GOS"
				},
				new Station
				{
					Name = "Grangetown (Cardiff)",
					Code = "GTN"
				},
				new Station
				{
					Name = "Grantham",
					Code = "GRA"
				},
				new Station
				{
					Name = "Grateley",
					Code = "GRT"
				},
				new Station
				{
					Name = "Gravelly Hill",
					Code = "GVH"
				},
				new Station
				{
					Name = "Gravesend",
					Code = "GRV"
				},
				new Station
				{
					Name = "Grays",
					Code = "GRY"
				},
				new Station
				{
					Name = "Great Ayton",
					Code = "GTA"
				},
				new Station
				{
					Name = "Great Bentley",
					Code = "GRB"
				},
				new Station
				{
					Name = "Great Chesterford",
					Code = "GRC"
				},
				new Station
				{
					Name = "Great Coates",
					Code = "GCT"
				},
				new Station
				{
					Name = "Great Malvern",
					Code = "GMV"
				},
				new Station
				{
					Name = "Great Missenden",
					Code = "GMN"
				},
				new Station
				{
					Name = "Great Yarmouth",
					Code = "GYM"
				},
				new Station
				{
					Name = "Green Lane",
					Code = "GNL"
				},
				new Station
				{
					Name = "Green Road",
					Code = "GNR"
				},
				new Station
				{
					Name = "Greenbank",
					Code = "GBK"
				},
				new Station
				{
					Name = "Greenfaulds",
					Code = "GRL"
				},
				new Station
				{
					Name = "Greenfield",
					Code = "GNF"
				},
				new Station
				{
					Name = "Greenford",
					Code = "GFD"
				},
				new Station
				{
					Name = "Greenhithe",
					Code = "GNH"
				},
				new Station
				{
					Name = "Greenock Central",
					Code = "GKC"
				},
				new Station
				{
					Name = "Greenock West",
					Code = "GKW"
				},
				new Station
				{
					Name = "Greenwich",
					Code = "GNW"
				},
				new Station
				{
					Name = "Gretna Green",
					Code = "GEA"
				},
				new Station
				{
					Name = "Grimsby Docks",
					Code = "GMD"
				},
				new Station
				{
					Name = "Grimsby Town",
					Code = "GMB"
				},
				new Station
				{
					Name = "Grindleford",
					Code = "GRN"
				},
				new Station
				{
					Name = "Grosmont",
					Code = "GMT"
				},
				new Station
				{
					Name = "Grove Park",
					Code = "GRP"
				},
				new Station
				{
					Name = "Guide Bridge",
					Code = "GUI"
				},
				new Station
				{
					Name = "Guildford",
					Code = "GLD"
				},
				new Station
				{
					Name = "Guiseley",
					Code = "GSY"
				},
				new Station
				{
					Name = "Gunnersbury",
					Code = "GUN"
				},
				new Station
				{
					Name = "Gunnislake",
					Code = "GSL"
				},
				new Station
				{
					Name = "Gunton",
					Code = "GNT"
				},
				new Station
				{
					Name = "Gwersyllt",
					Code = "GWE"
				},
				new Station
				{
					Name = "Gypsy Lane",
					Code = "GYP"
				},
				new Station
				{
					Name = "Habrough",
					Code = "HAB"
				},
				new Station
				{
					Name = "Hackbridge",
					Code = "HCB"
				},
				new Station
				{
					Name = "Hackney Central",
					Code = "HKC"
				},
				new Station
				{
					Name = "Hackney Downs",
					Code = "HAC"
				},
				new Station
				{
					Name = "Hackney Wick",
					Code = "HKW"
				},
				new Station
				{
					Name = "Haddenham & Thame Parkway",
					Code = "HDM"
				},
				new Station
				{
					Name = "Haddiscoe",
					Code = "HAD"
				},
				new Station
				{
					Name = "Hadfield",
					Code = "HDF"
				},
				new Station
				{
					Name = "Hadley Wood",
					Code = "HDW"
				},
				new Station
				{
					Name = "Hag Fold",
					Code = "HGF"
				},
				new Station
				{
					Name = "Haggerston",
					Code = "HGG"
				},
				new Station
				{
					Name = "Hagley",
					Code = "HAG"
				},
				new Station
				{
					Name = "Hairmyres",
					Code = "HMY"
				},
				new Station
				{
					Name = "Hale (Manchester)",
					Code = "HAL"
				},
				new Station
				{
					Name = "Halesworth",
					Code = "HAS"
				},
				new Station
				{
					Name = "Halewood",
					Code = "HED"
				},
				new Station
				{
					Name = "Halifax",
					Code = "HFX"
				},
				new Station
				{
					Name = "Hall Green",
					Code = "HLG"
				},
				new Station
				{
					Name = "Hall Road",
					Code = "HLR"
				},
				new Station
				{
					Name = "Halling",
					Code = "HAI"
				},
				new Station
				{
					Name = "Hall-i'-th'-Wood",
					Code = "HID"
				},
				new Station
				{
					Name = "Haltwhistle",
					Code = "HWH"
				},
				new Station
				{
					Name = "Ham Street",
					Code = "HMT"
				},
				new Station
				{
					Name = "Hamble",
					Code = "HME"
				},
				new Station
				{
					Name = "Hamilton Central",
					Code = "HNC"
				},
				new Station
				{
					Name = "Hamilton West",
					Code = "HNW"
				},
				new Station
				{
					Name = "Hammerton",
					Code = "HMM"
				},
				new Station
				{
					Name = "Hampden Park (Sussex)",
					Code = "HMD"
				},
				new Station
				{
					Name = "Hampstead Heath",
					Code = "HDH"
				},
				new Station
				{
					Name = "Hampton Court",
					Code = "HMC"
				},
				new Station
				{
					Name = "Hampton (London)",
					Code = "HMP"
				},
				new Station
				{
					Name = "Hampton Wick",
					Code = "HMW"
				},
				new Station
				{
					Name = "Hampton-in-Arden",
					Code = "HIA"
				},
				new Station
				{
					Name = "Hamstead (Birmingham)",
					Code = "HSD"
				},
				new Station
				{
					Name = "Hamworthy",
					Code = "HAM"
				},
				new Station
				{
					Name = "Hanborough",
					Code = "HND"
				},
				new Station
				{
					Name = "Handforth",
					Code = "HTH"
				},
				new Station
				{
					Name = "Hanwell",
					Code = "HAN"
				},
				new Station
				{
					Name = "Hapton",
					Code = "HPN"
				},
				new Station
				{
					Name = "Harlech",
					Code = "HRL"
				},
				new Station
				{
					Name = "Harlesden",
					Code = "HDN"
				},
				new Station
				{
					Name = "Harling Road",
					Code = "HRD"
				},
				new Station
				{
					Name = "Harlington (Beds)",
					Code = "HLN"
				},
				new Station
				{
					Name = "Harlow Mill",
					Code = "HWM"
				},
				new Station
				{
					Name = "Harlow Town",
					Code = "HWN"
				},
				new Station
				{
					Name = "Harold Wood",
					Code = "HRO"
				},
				new Station
				{
					Name = "Harpenden",
					Code = "HPD"
				},
				new Station
				{
					Name = "Harrietsham",
					Code = "HRM"
				},
				new Station
				{
					Name = "Harringay",
					Code = "HGY"
				},
				new Station
				{
					Name = "Harringay Green Lanes",
					Code = "HRY"
				},
				new Station
				{
					Name = "Harrington",
					Code = "HRR"
				},
				new Station
				{
					Name = "Harrogate",
					Code = "HGT"
				},
				new Station
				{
					Name = "Harrow & Wealdstone",
					Code = "HRW"
				},
				new Station
				{
					Name = "Harrow-on-the-Hill",
					Code = "HOH"
				},
				new Station
				{
					Name = "Hartford (Cheshire)",
					Code = "HTF"
				},
				new Station
				{
					Name = "Hartlebury",
					Code = "HBY"
				},
				new Station
				{
					Name = "Hartlepool",
					Code = "HPL"
				},
				new Station
				{
					Name = "Hartwood",
					Code = "HTW"
				},
				new Station
				{
					Name = "Harwich International",
					Code = "HPQ"
				},
				new Station
				{
					Name = "Harwich Town",
					Code = "HWC"
				},
				new Station
				{
					Name = "Haslemere",
					Code = "HSL"
				},
				new Station
				{
					Name = "Hassocks",
					Code = "HSK"
				},
				new Station
				{
					Name = "Hastings",
					Code = "HGS"
				},
				new Station
				{
					Name = "Hatch End",
					Code = "HTE"
				},
				new Station
				{
					Name = "Hatfield & Stainforth",
					Code = "HFS"
				},
				new Station
				{
					Name = "Hatfield (Herts)",
					Code = "HAT"
				},
				new Station
				{
					Name = "Hatfield Peverel",
					Code = "HAP"
				},
				new Station
				{
					Name = "Hathersage",
					Code = "HSG"
				},
				new Station
				{
					Name = "Hattersley",
					Code = "HTY"
				},
				new Station
				{
					Name = "Hatton",
					Code = "HTN"
				},
				new Station
				{
					Name = "Havant",
					Code = "HAV"
				},
				new Station
				{
					Name = "Havenhouse",
					Code = "HVN"
				},
				new Station
				{
					Name = "Haverfordwest",
					Code = "HVF"
				},
				new Station
				{
					Name = "Hawarden",
					Code = "HWD"
				},
				new Station
				{
					Name = "Hawarden Bridge",
					Code = "HWB"
				},
				new Station
				{
					Name = "Hawkhead",
					Code = "HKH"
				},
				new Station
				{
					Name = "Haydon Bridge",
					Code = "HDB"
				},
				new Station
				{
					Name = "Haydons Road",
					Code = "HYR"
				},
				new Station
				{
					Name = "Hayes & Harlington",
					Code = "HAY"
				},
				new Station
				{
					Name = "Hayes (Kent)",
					Code = "HYS"
				},
				new Station
				{
					Name = "Hayle",
					Code = "HYL"
				},
				new Station
				{
					Name = "Haymarket",
					Code = "HYM"
				},
				new Station
				{
					Name = "Haywards Heath",
					Code = "HHE"
				},
				new Station
				{
					Name = "Hazel Grove",
					Code = "HAZ"
				},
				new Station
				{
					Name = "Headcorn",
					Code = "HCN"
				},
				new Station
				{
					Name = "Headingley",
					Code = "HDY"
				},
				new Station
				{
					Name = "Headstone Lane",
					Code = "HDL"
				},
				new Station
				{
					Name = "Heald Green",
					Code = "HDG"
				},
				new Station
				{
					Name = "Healing",
					Code = "HLI"
				},
				new Station
				{
					Name = "Heath High Level",
					Code = "HHL"
				},
				new Station
				{
					Name = "Heath Low Level",
					Code = "HLL"
				},
				new Station
				{
					Name = "Heathrow Airport Terminal 4",
					Code = "HAF"
				},
				new Station
				{
					Name = "Heathrow Airport Terminal 5",
					Code = "HWV"
				},
				new Station
				{
					Name = "Heathrow Airport Terminals 1, 2 and 3",
					Code = "HXX"
				},
				new Station
				{
					Name = "Heaton Chapel",
					Code = "HTC"
				},
				new Station
				{
					Name = "Hebden Bridge",
					Code = "HBD"
				},
				new Station
				{
					Name = "Heckington",
					Code = "HEC"
				},
				new Station
				{
					Name = "Hedge End",
					Code = "HDE"
				},
				new Station
				{
					Name = "Hednesford",
					Code = "HNF"
				},
				new Station
				{
					Name = "Heighington",
					Code = "HEI"
				},
				new Station
				{
					Name = "Helensburgh Central",
					Code = "HLC"
				},
				new Station
				{
					Name = "Helensburgh Upper",
					Code = "HLU"
				},
				new Station
				{
					Name = "Hellifield",
					Code = "HLD"
				},
				new Station
				{
					Name = "Helmsdale",
					Code = "HMS"
				},
				new Station
				{
					Name = "Helsby",
					Code = "HSB"
				},
				new Station
				{
					Name = "Hemel Hempstead",
					Code = "HML"
				},
				new Station
				{
					Name = "Hendon",
					Code = "HEN"
				},
				new Station
				{
					Name = "Hengoed",
					Code = "HNG"
				},
				new Station
				{
					Name = "Henley-in-Arden",
					Code = "HNL"
				},
				new Station
				{
					Name = "Henley-on-Thames",
					Code = "HOT"
				},
				new Station
				{
					Name = "Hensall",
					Code = "HEL"
				},
				new Station
				{
					Name = "Hereford",
					Code = "HFD"
				},
				new Station
				{
					Name = "Herne Bay",
					Code = "HNB"
				},
				new Station
				{
					Name = "Herne Hill",
					Code = "HNH"
				},
				new Station
				{
					Name = "Hersham",
					Code = "HER"
				},
				new Station
				{
					Name = "Hertford East",
					Code = "HFE"
				},
				new Station
				{
					Name = "Hertford North",
					Code = "HFN"
				},
				new Station
				{
					Name = "Hessle",
					Code = "HES"
				},
				new Station
				{
					Name = "Heswall",
					Code = "HSW"
				},
				new Station
				{
					Name = "Hever",
					Code = "HEV"
				},
				new Station
				{
					Name = "Heworth",
					Code = "HEW"
				},
				new Station
				{
					Name = "Hexham",
					Code = "HEX"
				},
				new Station
				{
					Name = "Heyford",
					Code = "HYD"
				},
				new Station
				{
					Name = "Heysham Port",
					Code = "HHB"
				},
				new Station
				{
					Name = "High Brooms",
					Code = "HIB"
				},
				new Station
				{
					Name = "High Street (Glasgow)",
					Code = "HST"
				},
				new Station
				{
					Name = "High Street Kensington Underground",
					Code = "ZHS"
				},
				new Station
				{
					Name = "High Wycombe",
					Code = "HWY"
				},
				new Station
				{
					Name = "Higham (Kent)",
					Code = "HGM"
				},
				new Station
				{
					Name = "Highams Park",
					Code = "HIP"
				},
				new Station
				{
					Name = "Highbridge & Burnham",
					Code = "HIG"
				},
				new Station
				{
					Name = "Highbury & Islington",
					Code = "HHY"
				},
				new Station
				{
					Name = "Hightown",
					Code = "HTO"
				},
				new Station
				{
					Name = "Hildenborough",
					Code = "HLB"
				},
				new Station
				{
					Name = "Hillfoot",
					Code = "HLF"
				},
				new Station
				{
					Name = "Hillington East",
					Code = "HLE"
				},
				new Station
				{
					Name = "Hillington West",
					Code = "HLW"
				},
				new Station
				{
					Name = "Hillside",
					Code = "HIL"
				},
				new Station
				{
					Name = "Hilsea",
					Code = "HLS"
				},
				new Station
				{
					Name = "Hinchley Wood",
					Code = "HYW"
				},
				new Station
				{
					Name = "Hinckley (Leics)",
					Code = "HNK"
				},
				new Station
				{
					Name = "Hindley",
					Code = "HIN"
				},
				new Station
				{
					Name = "Hinton Admiral",
					Code = "HNA"
				},
				new Station
				{
					Name = "Hitchin",
					Code = "HIT"
				},
				new Station
				{
					Name = "Hither Green",
					Code = "HGR"
				},
				new Station
				{
					Name = "Hockley",
					Code = "HOC"
				},
				new Station
				{
					Name = "Hollingbourne",
					Code = "HBN"
				},
				new Station
				{
					Name = "Holmes Chapel",
					Code = "HCH"
				},
				new Station
				{
					Name = "Holmwood",
					Code = "HLM"
				},
				new Station
				{
					Name = "Holton Heath",
					Code = "HOL"
				},
				new Station
				{
					Name = "Holyhead",
					Code = "HHD"
				},
				new Station
				{
					Name = "Holytown",
					Code = "HLY"
				},
				new Station
				{
					Name = "Homerton",
					Code = "HMN"
				},
				new Station
				{
					Name = "Honeybourne",
					Code = "HYB"
				},
				new Station
				{
					Name = "Honiton",
					Code = "HON"
				},
				new Station
				{
					Name = "Honley",
					Code = "HOY"
				},
				new Station
				{
					Name = "Honor Oak Park",
					Code = "HPA"
				},
				new Station
				{
					Name = "Hook",
					Code = "HOK"
				},
				new Station
				{
					Name = "Hooton",
					Code = "HOO"
				},
				new Station
				{
					Name = "Hope (Derbyshire)",
					Code = "HOP"
				},
				new Station
				{
					Name = "Hope (Flintshire)",
					Code = "HPE"
				},
				new Station
				{
					Name = "Hopton Heath",
					Code = "HPT"
				},
				new Station
				{
					Name = "Horley",
					Code = "HOR"
				},
				new Station
				{
					Name = "Hornbeam Park",
					Code = "HBP"
				},
				new Station
				{
					Name = "Hornsey",
					Code = "HRN"
				},
				new Station
				{
					Name = "Horsforth",
					Code = "HRS"
				},
				new Station
				{
					Name = "Horsham",
					Code = "HRH"
				},
				new Station
				{
					Name = "Horsley",
					Code = "HSY"
				},
				new Station
				{
					Name = "Horton-in-Ribblesdale",
					Code = "HIR"
				},
				new Station
				{
					Name = "Horwich Parkway",
					Code = "HWI"
				},
				new Station
				{
					Name = "Hoscar",
					Code = "HSC"
				},
				new Station
				{
					Name = "Hough Green",
					Code = "HGN"
				},
				new Station
				{
					Name = "Hounslow",
					Code = "HOU"
				},
				new Station
				{
					Name = "Hove",
					Code = "HOV"
				},
				new Station
				{
					Name = "Hoveton & Wroxham",
					Code = "HXM"
				},
				new Station
				{
					Name = "How Wood (Herts)",
					Code = "HWW"
				},
				new Station
				{
					Name = "Howden",
					Code = "HOW"
				},
				new Station
				{
					Name = "Howwood (Renfrewshire)",
					Code = "HOZ"
				},
				new Station
				{
					Name = "Hoxton",
					Code = "HOX"
				},
				new Station
				{
					Name = "Hoylake",
					Code = "HYK"
				},
				new Station
				{
					Name = "Hubberts Bridge",
					Code = "HBB"
				},
				new Station
				{
					Name = "Hucknall",
					Code = "HKN"
				},
				new Station
				{
					Name = "Huddersfield",
					Code = "HUD"
				},
				new Station
				{
					Name = "Hull",
					Code = "HUL"
				},
				new Station
				{
					Name = "Humphrey Park",
					Code = "HUP"
				},
				new Station
				{
					Name = "Huncoat",
					Code = "HCT"
				},
				new Station
				{
					Name = "Hungerford",
					Code = "HGD"
				},
				new Station
				{
					Name = "Hunmanby",
					Code = "HUB"
				},
				new Station
				{
					Name = "Huntingdon",
					Code = "HUN"
				},
				new Station
				{
					Name = "Huntly",
					Code = "HNT"
				},
				new Station
				{
					Name = "Hunts Cross",
					Code = "HNX"
				},
				new Station
				{
					Name = "Hurst Green",
					Code = "HUR"
				},
				new Station
				{
					Name = "Hutton Cranswick",
					Code = "HUT"
				},
				new Station
				{
					Name = "Huyton",
					Code = "HUY"
				},
				new Station
				{
					Name = "Hyde Central",
					Code = "HYC"
				},
				new Station
				{
					Name = "Hyde North",
					Code = "HYT"
				},
				new Station
				{
					Name = "Hykeham",
					Code = "HKM"
				},
				new Station
				{
					Name = "Hyndland",
					Code = "HYN"
				},
				new Station
				{
					Name = "Hythe (Essex)",
					Code = "HYH"
				},
				new Station
				{
					Name = "IBM Halt",
					Code = "IBM"
				},
				new Station
				{
					Name = "Ifield",
					Code = "IFI"
				},
				new Station
				{
					Name = "Ilford",
					Code = "IFD"
				},
				new Station
				{
					Name = "Ilkley",
					Code = "ILK"
				},
				new Station
				{
					Name = "Imperial Wharf",
					Code = "IMW"
				},
				new Station
				{
					Name = "Ince & Elton",
					Code = "INE"
				},
				new Station
				{
					Name = "Ince (Manchester)",
					Code = "INC"
				},
				new Station
				{
					Name = "Ingatestone",
					Code = "INT"
				},
				new Station
				{
					Name = "Insch",
					Code = "INS"
				},
				new Station
				{
					Name = "Invergordon",
					Code = "IGD"
				},
				new Station
				{
					Name = "Invergowrie",
					Code = "ING"
				},
				new Station
				{
					Name = "Inverkeithing",
					Code = "INK"
				},
				new Station
				{
					Name = "Inverkip",
					Code = "INP"
				},
				new Station
				{
					Name = "Inverness",
					Code = "INV"
				},
				new Station
				{
					Name = "Invershin",
					Code = "INH"
				},
				new Station
				{
					Name = "Inverurie",
					Code = "INR"
				},
				new Station
				{
					Name = "Ipswich",
					Code = "IPS"
				},
				new Station
				{
					Name = "Irlam",
					Code = "IRL"
				},
				new Station
				{
					Name = "Irvine",
					Code = "IRV"
				},
				new Station
				{
					Name = "Isleworth",
					Code = "ISL"
				},
				new Station
				{
					Name = "Islip",
					Code = "ISP"
				},
				new Station
				{
					Name = "Iver",
					Code = "IVR"
				},
				new Station
				{
					Name = "Ivybridge",
					Code = "IVY"
				},
				new Station
				{
					Name = "Jewellery Quarter",
					Code = "JEQ"
				},
				new Station
				{
					Name = "Johnston (Pembs)",
					Code = "JOH"
				},
				new Station
				{
					Name = "Johnstone (Strathclyde)",
					Code = "JHN"
				},
				new Station
				{
					Name = "Jordanhill",
					Code = "JOR"
				},
				new Station
				{
					Name = "Kearsley (Manchester)",
					Code = "KSL"
				},
				new Station
				{
					Name = "Kearsney (Kent)",
					Code = "KSN"
				},
				new Station
				{
					Name = "Keighley",
					Code = "KEI"
				},
				new Station
				{
					Name = "Keith",
					Code = "KEH"
				},
				new Station
				{
					Name = "Kelvedon",
					Code = "KEL"
				},
				new Station
				{
					Name = "Kelvindale",
					Code = "KVD"
				},
				new Station
				{
					Name = "Kemble",
					Code = "KEM"
				},
				new Station
				{
					Name = "Kempston Hardwick",
					Code = "KMH"
				},
				new Station
				{
					Name = "Kempton Park Racecourse",
					Code = "KMP"
				},
				new Station
				{
					Name = "Kemsing",
					Code = "KMS"
				},
				new Station
				{
					Name = "Kemsley",
					Code = "KML"
				},
				new Station
				{
					Name = "Kendal",
					Code = "KEN"
				},
				new Station
				{
					Name = "Kenley",
					Code = "KLY"
				},
				new Station
				{
					Name = "Kennett",
					Code = "KNE"
				},
				new Station
				{
					Name = "Kennishead",
					Code = "KNS"
				},
				new Station
				{
					Name = "Kensal Green",
					Code = "KNL"
				},
				new Station
				{
					Name = "Kensal Rise",
					Code = "KNR"
				},
				new Station
				{
					Name = "Kensington Olympia",
					Code = "KPA"
				},
				new Station
				{
					Name = "Kent House",
					Code = "KTH"
				},
				new Station
				{
					Name = "Kentish Town",
					Code = "KTN"
				},
				new Station
				{
					Name = "Kentish Town West",
					Code = "KTW"
				},
				new Station
				{
					Name = "Kenton",
					Code = "KNT"
				},
				new Station
				{
					Name = "Kents Bank",
					Code = "KBK"
				},
				new Station
				{
					Name = "Kettering",
					Code = "KET"
				},
				new Station
				{
					Name = "Kew Bridge",
					Code = "KWB"
				},
				new Station
				{
					Name = "Kew Gardens",
					Code = "KWG"
				},
				new Station
				{
					Name = "Keyham",
					Code = "KEY"
				},
				new Station
				{
					Name = "Keynsham",
					Code = "KYN"
				},
				new Station
				{
					Name = "Kidbrooke",
					Code = "KDB"
				},
				new Station
				{
					Name = "Kidderminster",
					Code = "KID"
				},
				new Station
				{
					Name = "Kidsgrove",
					Code = "KDG"
				},
				new Station
				{
					Name = "Kidwelly",
					Code = "KWL"
				},
				new Station
				{
					Name = "Kilburn High Road",
					Code = "KBN"
				},
				new Station
				{
					Name = "Kildale",
					Code = "KLD"
				},
				new Station
				{
					Name = "Kildonan",
					Code = "KIL"
				},
				new Station
				{
					Name = "Kilgetty",
					Code = "KGT"
				},
				new Station
				{
					Name = "Kilmarnock",
					Code = "KMK"
				},
				new Station
				{
					Name = "Kilmaurs",
					Code = "KLM"
				},
				new Station
				{
					Name = "Kilpatrick",
					Code = "KPT"
				},
				new Station
				{
					Name = "Kilwinning",
					Code = "KWN"
				},
				new Station
				{
					Name = "Kinbrace",
					Code = "KBC"
				},
				new Station
				{
					Name = "Kingham",
					Code = "KGM"
				},
				new Station
				{
					Name = "Kinghorn",
					Code = "KGH"
				},
				new Station
				{
					Name = "Kings Langley",
					Code = "KGL"
				},
				new Station
				{
					Name = "Kings Lynn",
					Code = "KLN"
				},
				new Station
				{
					Name = "Kings Norton",
					Code = "KNN"
				},
				new Station
				{
					Name = "Kings Nympton",
					Code = "KGN"
				},
				new Station
				{
					Name = "Kings Park",
					Code = "KGP"
				},
				new Station
				{
					Name = "Kings Sutton",
					Code = "KGS"
				},
				new Station
				{
					Name = "Kingsknowe",
					Code = "KGE"
				},
				new Station
				{
					Name = "Kingston",
					Code = "KNG"
				},
				new Station
				{
					Name = "Kingswood",
					Code = "KND"
				},
				new Station
				{
					Name = "Kingussie",
					Code = "KIN"
				},
				new Station
				{
					Name = "Kintbury",
					Code = "KIT"
				},
				new Station
				{
					Name = "Kirby Cross",
					Code = "KBX"
				},
				new Station
				{
					Name = "Kirk Sandall",
					Code = "KKS"
				},
				new Station
				{
					Name = "Kirkby (Merseyside)",
					Code = "KIR"
				},
				new Station
				{
					Name = "Kirkby Stephen",
					Code = "KSW"
				},
				new Station
				{
					Name = "Kirkby-in-Ashfield",
					Code = "KKB"
				},
				new Station
				{
					Name = "Kirkby-in-Furness",
					Code = "KBF"
				},
				new Station
				{
					Name = "Kirkcaldy",
					Code = "KDY"
				},
				new Station
				{
					Name = "Kirkconnel",
					Code = "KRK"
				},
				new Station
				{
					Name = "Kirkdale",
					Code = "KKD"
				},
				new Station
				{
					Name = "Kirkham & Wesham",
					Code = "KKM"
				},
				new Station
				{
					Name = "Kirkhill",
					Code = "KKH"
				},
				new Station
				{
					Name = "Kirknewton",
					Code = "KKN"
				},
				new Station
				{
					Name = "Kirkwood",
					Code = "KWD"
				},
				new Station
				{
					Name = "Kirton Lindsey",
					Code = "KTL"
				},
				new Station
				{
					Name = "Kiveton Bridge",
					Code = "KIV"
				},
				new Station
				{
					Name = "Kiveton Park",
					Code = "KVP"
				},
				new Station
				{
					Name = "Knaresborough",
					Code = "KNA"
				},
				new Station
				{
					Name = "Knebworth",
					Code = "KBW"
				},
				new Station
				{
					Name = "Knighton",
					Code = "KNI"
				},
				new Station
				{
					Name = "Knockholt",
					Code = "KCK"
				},
				new Station
				{
					Name = "Knottingley",
					Code = "KNO"
				},
				new Station
				{
					Name = "Knucklas",
					Code = "KNU"
				},
				new Station
				{
					Name = "Knutsford",
					Code = "KNF"
				},
				new Station
				{
					Name = "Kyle of Lochalsh",
					Code = "KYL"
				},
				new Station
				{
					Name = "Ladybank",
					Code = "LDY"
				},
				new Station
				{
					Name = "Ladywell",
					Code = "LAD"
				},
				new Station
				{
					Name = "Laindon",
					Code = "LAI"
				},
				new Station
				{
					Name = "Lairg",
					Code = "LRG"
				},
				new Station
				{
					Name = "Lake",
					Code = "LKE"
				},
				new Station
				{
					Name = "Lakenheath",
					Code = "LAK"
				},
				new Station
				{
					Name = "Lamphey",
					Code = "LAM"
				},
				new Station
				{
					Name = "Lanark",
					Code = "LNK"
				},
				new Station
				{
					Name = "Lancaster",
					Code = "LAN"
				},
				new Station
				{
					Name = "Lancing",
					Code = "LAC"
				},
				new Station
				{
					Name = "Landywood",
					Code = "LAW"
				},
				new Station
				{
					Name = "Langbank",
					Code = "LGB"
				},
				new Station
				{
					Name = "Langho",
					Code = "LHO"
				},
				new Station
				{
					Name = "Langley (Berks)",
					Code = "LNY"
				},
				new Station
				{
					Name = "Langley Green",
					Code = "LGG"
				},
				new Station
				{
					Name = "Langley Mill",
					Code = "LGM"
				},
				new Station
				{
					Name = "Langside",
					Code = "LGS"
				},
				new Station
				{
					Name = "Langwathby",
					Code = "LGW"
				},
				new Station
				{
					Name = "Langwith-Whaley Thorns",
					Code = "LAG"
				},
				new Station
				{
					Name = "Lapford",
					Code = "LAP"
				},
				new Station
				{
					Name = "Lapworth",
					Code = "LPW"
				},
				new Station
				{
					Name = "Larbert",
					Code = "LBT"
				},
				new Station
				{
					Name = "Largs",
					Code = "LAR"
				},
				new Station
				{
					Name = "Larkhall",
					Code = "LRH"
				},
				new Station
				{
					Name = "Laurencekirk",
					Code = "LAU"
				},
				new Station
				{
					Name = "Lawrence Hill",
					Code = "LWH"
				},
				new Station
				{
					Name = "Layton (Lancs)",
					Code = "LAY"
				},
				new Station
				{
					Name = "Lazonby & Kirkoswald",
					Code = "LZB"
				},
				new Station
				{
					Name = "Lea Green",
					Code = "LEG"
				},
				new Station
				{
					Name = "Lea Hall",
					Code = "LEH"
				},
				new Station
				{
					Name = "Leagrave",
					Code = "LEA"
				},
				new Station
				{
					Name = "Lealholm",
					Code = "LHM"
				},
				new Station
				{
					Name = "Leamington Spa",
					Code = "LMS"
				},
				new Station
				{
					Name = "Leasowe",
					Code = "LSW"
				},
				new Station
				{
					Name = "Leatherhead",
					Code = "LHD"
				},
				new Station
				{
					Name = "Ledbury",
					Code = "LED"
				},
				new Station
				{
					Name = "Lee (London)",
					Code = "LEE"
				},
				new Station
				{
					Name = "Leeds",
					Code = "LDS"
				},
				new Station
				{
					Name = "Leicester",
					Code = "LEI"
				},
				new Station
				{
					Name = "Leigh (Kent)",
					Code = "LIH"
				},
				new Station
				{
					Name = "Leigh-on-Sea",
					Code = "LES"
				},
				new Station
				{
					Name = "Leighton Buzzard",
					Code = "LBZ"
				},
				new Station
				{
					Name = "Lelant",
					Code = "LEL"
				},
				new Station
				{
					Name = "Lelant Saltings",
					Code = "LTS"
				},
				new Station
				{
					Name = "Lenham",
					Code = "LEN"
				},
				new Station
				{
					Name = "Lenzie",
					Code = "LNZ"
				},
				new Station
				{
					Name = "Leominster",
					Code = "LEO"
				},
				new Station
				{
					Name = "Letchworth Garden City",
					Code = "LET"
				},
				new Station
				{
					Name = "Leuchars (for St. Andrews)",
					Code = "LEU"
				},
				new Station
				{
					Name = "Levenshulme",
					Code = "LVM"
				},
				new Station
				{
					Name = "Lewes",
					Code = "LWS"
				},
				new Station
				{
					Name = "Lewisham",
					Code = "LEW"
				},
				new Station
				{
					Name = "Leyland",
					Code = "LEY"
				},
				new Station
				{
					Name = "Leyton Midland Road",
					Code = "LEM"
				},
				new Station
				{
					Name = "Leytonstone High Road",
					Code = "LER"
				},
				new Station
				{
					Name = "Lichfield City",
					Code = "LIC"
				},
				new Station
				{
					Name = "Lichfield Trent Valley",
					Code = "LTV"
				},
				new Station
				{
					Name = "Lidlington",
					Code = "LID"
				},
				new Station
				{
					Name = "Limehouse",
					Code = "LHS"
				},
				new Station
				{
					Name = "Lincoln Central",
					Code = "LCN"
				},
				new Station
				{
					Name = "Lingfield",
					Code = "LFD"
				},
				new Station
				{
					Name = "Lingwood",
					Code = "LGD"
				},
				new Station
				{
					Name = "Linlithgow",
					Code = "LIN"
				},
				new Station
				{
					Name = "Liphook",
					Code = "LIP"
				},
				new Station
				{
					Name = "Liskeard",
					Code = "LSK"
				},
				new Station
				{
					Name = "Liss",
					Code = "LIS"
				},
				new Station
				{
					Name = "Lisvane & Thornhill",
					Code = "LVT"
				},
				new Station
				{
					Name = "Little Kimble",
					Code = "LTK"
				},
				new Station
				{
					Name = "Little Sutton",
					Code = "LTT"
				},
				new Station
				{
					Name = "Littleborough",
					Code = "LTL"
				},
				new Station
				{
					Name = "Littlehampton",
					Code = "LIT"
				},
				new Station
				{
					Name = "Littlehaven",
					Code = "LVN"
				},
				new Station
				{
					Name = "Littleport",
					Code = "LTP"
				},
				new Station
				{
					Name = "Liverpool Central",
					Code = "LVC"
				},
				new Station
				{
					Name = "Liverpool James Street",
					Code = "LVJ"
				},
				new Station
				{
					Name = "Liverpool Lime Street",
					Code = "LIV"
				},
				new Station
				{
					Name = "Liverpool South Parkway",
					Code = "LPY"
				},
				new Station
				{
					Name = "Livingston North",
					Code = "LSN"
				},
				new Station
				{
					Name = "Livingston South",
					Code = "LVG"
				},
				new Station
				{
					Name = "Llanaber",
					Code = "LLA"
				},
				new Station
				{
					Name = "Llanbedr",
					Code = "LBR"
				},
				new Station
				{
					Name = "Llanbister Road",
					Code = "LLT"
				},
				new Station
				{
					Name = "Llanbradach",
					Code = "LNB"
				},
				new Station
				{
					Name = "Llandaf",
					Code = "LLN"
				},
				new Station
				{
					Name = "Llandanwg",
					Code = "LDN"
				},
				new Station
				{
					Name = "Llandecwyn",
					Code = "LLC"
				},
				new Station
				{
					Name = "Llandeilo",
					Code = "LLL"
				},
				new Station
				{
					Name = "Llandovery",
					Code = "LLV"
				},
				new Station
				{
					Name = "Llandrindod",
					Code = "LLO"
				},
				new Station
				{
					Name = "Llandudno",
					Code = "LLD"
				},
				new Station
				{
					Name = "Llandudno Junction",
					Code = "LLJ"
				},
				new Station
				{
					Name = "Llandybie",
					Code = "LLI"
				},
				new Station
				{
					Name = "Llanelli",
					Code = "LLE"
				},
				new Station
				{
					Name = "Llanfairfechan",
					Code = "LLF"
				},
				new Station
				{
					Name = "Llanfairpwll",
					Code = "LPG"
				},
				new Station
				{
					Name = "Llangadog",
					Code = "LLG"
				},
				new Station
				{
					Name = "Llangammarch",
					Code = "LLM"
				},
				new Station
				{
					Name = "Llangennech",
					Code = "LLH"
				},
				new Station
				{
					Name = "Llangynllo",
					Code = "LGO"
				},
				new Station
				{
					Name = "Llanharan",
					Code = "LLR"
				},
				new Station
				{
					Name = "Llanhilleth",
					Code = "LTH"
				},
				new Station
				{
					Name = "Llanishen",
					Code = "LLS"
				},
				new Station
				{
					Name = "Llanrwst",
					Code = "LWR"
				},
				new Station
				{
					Name = "Llansamlet",
					Code = "LAS"
				},
				new Station
				{
					Name = "Llantwit Major",
					Code = "LWM"
				},
				new Station
				{
					Name = "Llanwrda",
					Code = "LNR"
				},
				new Station
				{
					Name = "Llanwrtyd",
					Code = "LNW"
				},
				new Station
				{
					Name = "Llwyngwril",
					Code = "LLW"
				},
				new Station
				{
					Name = "Llwynypia",
					Code = "LLY"
				},
				new Station
				{
					Name = "Loch Awe",
					Code = "LHA"
				},
				new Station
				{
					Name = "Loch Eil Outward Bound",
					Code = "LHE"
				},
				new Station
				{
					Name = "Lochailort",
					Code = "LCL"
				},
				new Station
				{
					Name = "Locheilside",
					Code = "LCS"
				},
				new Station
				{
					Name = "Lochgelly",
					Code = "LCG"
				},
				new Station
				{
					Name = "Lochluichart",
					Code = "LCC"
				},
				new Station
				{
					Name = "Lochwinnoch",
					Code = "LHW"
				},
				new Station
				{
					Name = "Lockerbie",
					Code = "LOC"
				},
				new Station
				{
					Name = "Lockwood",
					Code = "LCK"
				},
				new Station
				{
					Name = "London Blackfriars",
					Code = "BFR"
				},
				new Station
				{
					Name = "London Bridge",
					Code = "LBG"
				},
				new Station
				{
					Name = "London Cannon Street",
					Code = "CST"
				},
				new Station
				{
					Name = "London Charing Cross",
					Code = "CHX"
				},
				new Station
				{
					Name = "London Euston",
					Code = "EUS"
				},
				new Station
				{
					Name = "London Fenchurch Street",
					Code = "FST"
				},
				new Station
				{
					Name = "London Fields",
					Code = "LOF"
				},
				new Station
				{
					Name = "London Kings Cross",
					Code = "KGX"
				},
				new Station
				{
					Name = "London Liverpool Street",
					Code = "LST"
				},
				new Station
				{
					Name = "London Marylebone",
					Code = "MYB"
				},
				new Station
				{
					Name = "London Paddington",
					Code = "PAD"
				},
				new Station
				{
					Name = "London Road (Brighton)",
					Code = "LRB"
				},
				new Station
				{
					Name = "London Road (Guildford)",
					Code = "LRD"
				},
				new Station
				{
					Name = "London St Pancras International",
					Code = "STP"
				},
				new Station
				{
					Name = "London St Pancras (Intl)",
					Code = "SPX"
				},
				new Station
				{
					Name = "London Victoria",
					Code = "VIC"
				},
				new Station
				{
					Name = "London Waterloo",
					Code = "WAT"
				},
				new Station
				{
					Name = "London Waterloo East",
					Code = "WAE"
				},
				new Station
				{
					Name = "Long Buckby",
					Code = "LBK"
				},
				new Station
				{
					Name = "Long Eaton",
					Code = "LGE"
				},
				new Station
				{
					Name = "Long Preston",
					Code = "LPR"
				},
				new Station
				{
					Name = "Longbeck",
					Code = "LGK"
				},
				new Station
				{
					Name = "Longbridge",
					Code = "LOB"
				},
				new Station
				{
					Name = "Longcross",
					Code = "LNG"
				},
				new Station
				{
					Name = "Longfield",
					Code = "LGF"
				},
				new Station
				{
					Name = "Longniddry",
					Code = "LND"
				},
				new Station
				{
					Name = "Longport",
					Code = "LPT"
				},
				new Station
				{
					Name = "Longton",
					Code = "LGN"
				},
				new Station
				{
					Name = "Looe",
					Code = "LOO"
				},
				new Station
				{
					Name = "Lostock",
					Code = "LOT"
				},
				new Station
				{
					Name = "Lostock Gralam",
					Code = "LTG"
				},
				new Station
				{
					Name = "Lostock Hall",
					Code = "LOH"
				},
				new Station
				{
					Name = "Lostwithiel",
					Code = "LOS"
				},
				new Station
				{
					Name = "Loughborough",
					Code = "LBO"
				},
				new Station
				{
					Name = "Loughborough Junction",
					Code = "LGJ"
				},
				new Station
				{
					Name = "Lowdham",
					Code = "LOW"
				},
				new Station
				{
					Name = "Lower Sydenham",
					Code = "LSY"
				},
				new Station
				{
					Name = "Lowestoft",
					Code = "LWT"
				},
				new Station
				{
					Name = "Ludlow",
					Code = "LUD"
				},
				new Station
				{
					Name = "Luton",
					Code = "LUT"
				},
				new Station
				{
					Name = "Luton Airport Parkway",
					Code = "LTN"
				},
				new Station
				{
					Name = "Luxulyan",
					Code = "LUX"
				},
				new Station
				{
					Name = "Lydney",
					Code = "LYD"
				},
				new Station
				{
					Name = "Lye (West Midlands)",
					Code = "LYE"
				},
				new Station
				{
					Name = "Lymington Pier",
					Code = "LYP"
				},
				new Station
				{
					Name = "Lymington Town",
					Code = "LYT"
				},
				new Station
				{
					Name = "Lympstone Commando",
					Code = "LYC"
				},
				new Station
				{
					Name = "Lympstone Village",
					Code = "LYM"
				},
				new Station
				{
					Name = "Lytham",
					Code = "LTM"
				},
				new Station
				{
					Name = "Macclesfield",
					Code = "MAC"
				},
				new Station
				{
					Name = "Machynlleth",
					Code = "MCN"
				},
				new Station
				{
					Name = "Maesteg",
					Code = "MST"
				},
				new Station
				{
					Name = "Maesteg (Ewenny Road)",
					Code = "MEW"
				},
				new Station
				{
					Name = "Maghull",
					Code = "MAG"
				},
				new Station
				{
					Name = "Maiden Newton",
					Code = "MDN"
				},
				new Station
				{
					Name = "Maidenhead",
					Code = "MAI"
				},
				new Station
				{
					Name = "Maidstone Barracks",
					Code = "MDB"
				},
				new Station
				{
					Name = "Maidstone East",
					Code = "MDE"
				},
				new Station
				{
					Name = "Maidstone West",
					Code = "MDW"
				},
				new Station
				{
					Name = "Malden Manor",
					Code = "MAL"
				},
				new Station
				{
					Name = "Mallaig",
					Code = "MLG"
				},
				new Station
				{
					Name = "Malton",
					Code = "MLT"
				},
				new Station
				{
					Name = "Malvern Link",
					Code = "MVL"
				},
				new Station
				{
					Name = "Manchester Airport",
					Code = "MIA"
				},
				new Station
				{
					Name = "Manchester Oxford Road",
					Code = "MCO"
				},
				new Station
				{
					Name = "Manchester Piccadilly",
					Code = "MAN"
				},
				new Station
				{
					Name = "Manchester United Football Ground",
					Code = "MUF"
				},
				new Station
				{
					Name = "Manchester Victoria",
					Code = "MCV"
				},
				new Station
				{
					Name = "Manea",
					Code = "MNE"
				},
				new Station
				{
					Name = "Manningtree",
					Code = "MNG"
				},
				new Station
				{
					Name = "Manor Park",
					Code = "MNP"
				},
				new Station
				{
					Name = "Manor Road",
					Code = "MNR"
				},
				new Station
				{
					Name = "Manorbier",
					Code = "MRB"
				},
				new Station
				{
					Name = "Manors",
					Code = "MAS"
				},
				new Station
				{
					Name = "Mansfield",
					Code = "MFT"
				},
				new Station
				{
					Name = "Mansfield Woodhouse",
					Code = "MSW"
				},
				new Station
				{
					Name = "March",
					Code = "MCH"
				},
				new Station
				{
					Name = "Marden (Kent)",
					Code = "MRN"
				},
				new Station
				{
					Name = "Margate",
					Code = "MAR"
				},
				new Station
				{
					Name = "Market Harborough",
					Code = "MHR"
				},
				new Station
				{
					Name = "Market Rasen",
					Code = "MKR"
				},
				new Station
				{
					Name = "Markinch",
					Code = "MNC"
				},
				new Station
				{
					Name = "Marks Tey",
					Code = "MKT"
				},
				new Station
				{
					Name = "Marlow",
					Code = "MLW"
				},
				new Station
				{
					Name = "Marple",
					Code = "MPL"
				},
				new Station
				{
					Name = "Marsden (Yorks)",
					Code = "MSN"
				},
				new Station
				{
					Name = "Marske",
					Code = "MSK"
				},
				new Station
				{
					Name = "Marston Green",
					Code = "MGN"
				},
				new Station
				{
					Name = "Martin Mill",
					Code = "MTM"
				},
				new Station
				{
					Name = "Martins Heron",
					Code = "MAO"
				},
				new Station
				{
					Name = "Marton",
					Code = "MTO"
				},
				new Station
				{
					Name = "Maryhill",
					Code = "MYH"
				},
				new Station
				{
					Name = "Maryland",
					Code = "MYL"
				},
				new Station
				{
					Name = "Maryport",
					Code = "MRY"
				},
				new Station
				{
					Name = "Matlock",
					Code = "MAT"
				},
				new Station
				{
					Name = "Matlock Bath",
					Code = "MTB"
				},
				new Station
				{
					Name = "Mauldeth Road",
					Code = "MAU"
				},
				new Station
				{
					Name = "Maxwell Park",
					Code = "MAX"
				},
				new Station
				{
					Name = "Maybole",
					Code = "MAY"
				},
				new Station
				{
					Name = "Maze Hill",
					Code = "MZH"
				},
				new Station
				{
					Name = "Meadowhall",
					Code = "MHS"
				},
				new Station
				{
					Name = "Meldreth",
					Code = "MEL"
				},
				new Station
				{
					Name = "Melksham",
					Code = "MKM"
				},
				new Station
				{
					Name = "Melton Mowbray",
					Code = "MMO"
				},
				new Station
				{
					Name = "Melton (Suffolk)",
					Code = "MES"
				},
				new Station
				{
					Name = "Menheniot",
					Code = "MEN"
				},
				new Station
				{
					Name = "Menston",
					Code = "MNN"
				},
				new Station
				{
					Name = "Meols",
					Code = "MEO"
				},
				new Station
				{
					Name = "Meols Cop",
					Code = "MEC"
				},
				new Station
				{
					Name = "Meopham",
					Code = "MEP"
				},
				new Station
				{
					Name = "Merryton",
					Code = "MEY"
				},
				new Station
				{
					Name = "Merstham",
					Code = "MHM"
				},
				new Station
				{
					Name = "Merthyr Tydfil",
					Code = "MER"
				},
				new Station
				{
					Name = "Merthyr Vale",
					Code = "MEV"
				},
				new Station
				{
					Name = "Metheringham",
					Code = "MGM"
				},
				new Station
				{
					Name = "MetroCentre",
					Code = "MCE"
				},
				new Station
				{
					Name = "Mexborough",
					Code = "MEX"
				},
				new Station
				{
					Name = "Micheldever",
					Code = "MIC"
				},
				new Station
				{
					Name = "Micklefield",
					Code = "MIK"
				},
				new Station
				{
					Name = "Middlesbrough",
					Code = "MBR"
				},
				new Station
				{
					Name = "Middlewood",
					Code = "MDL"
				},
				new Station
				{
					Name = "Midgham",
					Code = "MDG"
				},
				new Station
				{
					Name = "Milford Haven",
					Code = "MFH"
				},
				new Station
				{
					Name = "Milford (Surrey)",
					Code = "MLF"
				},
				new Station
				{
					Name = "Mill Hill Broadway",
					Code = "MIL"
				},
				new Station
				{
					Name = "Mill Hill (Lancs)",
					Code = "MLH"
				},
				new Station
				{
					Name = "Millbrook (Beds)",
					Code = "MLB"
				},
				new Station
				{
					Name = "Millbrook (Hants)",
					Code = "MBK"
				},
				new Station
				{
					Name = "Milliken Park",
					Code = "MIN"
				},
				new Station
				{
					Name = "Millom",
					Code = "MLM"
				},
				new Station
				{
					Name = "Mills Hill (Manchester)",
					Code = "MIH"
				},
				new Station
				{
					Name = "Milngavie",
					Code = "MLN"
				},
				new Station
				{
					Name = "Milton Keynes Central",
					Code = "MKC"
				},
				new Station
				{
					Name = "Minffordd",
					Code = "MFF"
				},
				new Station
				{
					Name = "Minster",
					Code = "MSR"
				},
				new Station
				{
					Name = "Mirfield",
					Code = "MIR"
				},
				new Station
				{
					Name = "Mistley",
					Code = "MIS"
				},
				new Station
				{
					Name = "Mitcham Eastfields",
					Code = "MTC"
				},
				new Station
				{
					Name = "Mitcham Junction",
					Code = "MIJ"
				},
				new Station
				{
					Name = "Mobberley",
					Code = "MOB"
				},
				new Station
				{
					Name = "Monifieth",
					Code = "MON"
				},
				new Station
				{
					Name = "Monks Risborough",
					Code = "MRS"
				},
				new Station
				{
					Name = "Montpelier",
					Code = "MTP"
				},
				new Station
				{
					Name = "Montrose",
					Code = "MTS"
				},
				new Station
				{
					Name = "Moorfields",
					Code = "MRF"
				},
				new Station
				{
					Name = "Moorgate",
					Code = "MOG"
				},
				new Station
				{
					Name = "Moorside",
					Code = "MSD"
				},
				new Station
				{
					Name = "Moorthorpe",
					Code = "MRP"
				},
				new Station
				{
					Name = "Morar",
					Code = "MRR"
				},
				new Station
				{
					Name = "Morchard Road",
					Code = "MRD"
				},
				new Station
				{
					Name = "Morden South",
					Code = "MDS"
				},
				new Station
				{
					Name = "Morecambe",
					Code = "MCM"
				},
				new Station
				{
					Name = "Moreton (Dorset)",
					Code = "MTN"
				},
				new Station
				{
					Name = "Moreton (Merseyside)",
					Code = "MRT"
				},
				new Station
				{
					Name = "Moreton-in-Marsh",
					Code = "MIM"
				},
				new Station
				{
					Name = "Morfa Mawddach",
					Code = "MFA"
				},
				new Station
				{
					Name = "Morley",
					Code = "MLY"
				},
				new Station
				{
					Name = "Morpeth",
					Code = "MPT"
				},
				new Station
				{
					Name = "Mortimer",
					Code = "MOR"
				},
				new Station
				{
					Name = "Mortlake",
					Code = "MTL"
				},
				new Station
				{
					Name = "Moses Gate",
					Code = "MSS"
				},
				new Station
				{
					Name = "Moss Side",
					Code = "MOS"
				},
				new Station
				{
					Name = "Mossley Hill",
					Code = "MSH"
				},
				new Station
				{
					Name = "Mossley (Manchester)",
					Code = "MSL"
				},
				new Station
				{
					Name = "Mosspark",
					Code = "MPK"
				},
				new Station
				{
					Name = "Moston",
					Code = "MSO"
				},
				new Station
				{
					Name = "Motherwell",
					Code = "MTH"
				},
				new Station
				{
					Name = "Motspur Park",
					Code = "MOT"
				},
				new Station
				{
					Name = "Mottingham",
					Code = "MTG"
				},
				new Station
				{
					Name = "Mottisfont & Dunbridge",
					Code = "DBG"
				},
				new Station
				{
					Name = "Mouldsworth",
					Code = "MLD"
				},
				new Station
				{
					Name = "Moulsecoomb",
					Code = "MCB"
				},
				new Station
				{
					Name = "Mount Florida",
					Code = "MFL"
				},
				new Station
				{
					Name = "Mount Vernon",
					Code = "MTV"
				},
				new Station
				{
					Name = "Mountain Ash",
					Code = "MTA"
				},
				new Station
				{
					Name = "Muir of Ord",
					Code = "MOO"
				},
				new Station
				{
					Name = "Muirend",
					Code = "MUI"
				},
				new Station
				{
					Name = "Musselburgh",
					Code = "MUB"
				},
				new Station
				{
					Name = "Mytholmroyd",
					Code = "MYT"
				},
				new Station
				{
					Name = "Nafferton",
					Code = "NFN"
				},
				new Station
				{
					Name = "Nailsea & Backwell",
					Code = "NLS"
				},
				new Station
				{
					Name = "Nairn",
					Code = "NRN"
				},
				new Station
				{
					Name = "Nantwich",
					Code = "NAN"
				},
				new Station
				{
					Name = "Narberth",
					Code = "NAR"
				},
				new Station
				{
					Name = "Narborough",
					Code = "NBR"
				},
				new Station
				{
					Name = "Navigation Road",
					Code = "NVR"
				},
				new Station
				{
					Name = "Neath",
					Code = "NTH"
				},
				new Station
				{
					Name = "Needham Market",
					Code = "NMT"
				},
				new Station
				{
					Name = "Neilston",
					Code = "NEI"
				},
				new Station
				{
					Name = "Nelson",
					Code = "NEL"
				},
				new Station
				{
					Name = "Neston",
					Code = "NES"
				},
				new Station
				{
					Name = "Netherfield",
					Code = "NET"
				},
				new Station
				{
					Name = "Nethertown",
					Code = "NRT"
				},
				new Station
				{
					Name = "Netley",
					Code = "NTL"
				},
				new Station
				{
					Name = "New Barnet",
					Code = "NBA"
				},
				new Station
				{
					Name = "New Beckenham",
					Code = "NBC"
				},
				new Station
				{
					Name = "New Brighton",
					Code = "NBN"
				},
				new Station
				{
					Name = "New Clee",
					Code = "NCE"
				},
				new Station
				{
					Name = "New Cross",
					Code = "NWX"
				},
				new Station
				{
					Name = "New Cross Gate",
					Code = "NXG"
				},
				new Station
				{
					Name = "New Cumnock",
					Code = "NCK"
				},
				new Station
				{
					Name = "New Eltham",
					Code = "NEH"
				},
				new Station
				{
					Name = "New Holland",
					Code = "NHL"
				},
				new Station
				{
					Name = "New Hythe",
					Code = "NHE"
				},
				new Station
				{
					Name = "New Lane",
					Code = "NLN"
				},
				new Station
				{
					Name = "New Malden",
					Code = "NEM"
				},
				new Station
				{
					Name = "New Mills Central",
					Code = "NMC"
				},
				new Station
				{
					Name = "New Mills Newtown",
					Code = "NMN"
				},
				new Station
				{
					Name = "New Milton",
					Code = "NWM"
				},
				new Station
				{
					Name = "New Pudsey",
					Code = "NPD"
				},
				new Station
				{
					Name = "New Southgate",
					Code = "NSG"
				},
				new Station
				{
					Name = "Newark Castle",
					Code = "NCT"
				},
				new Station
				{
					Name = "Newark North Gate",
					Code = "NNG"
				},
				new Station
				{
					Name = "Newbridge",
					Code = "NBE"
				},
				new Station
				{
					Name = "Newbury",
					Code = "NBY"
				},
				new Station
				{
					Name = "Newbury Racecourse",
					Code = "NRC"
				},
				new Station
				{
					Name = "Newcastle",
					Code = "NCL"
				},
				new Station
				{
					Name = "Newcraighall",
					Code = "NEW"
				},
				new Station
				{
					Name = "Newhaven Harbour",
					Code = "NVH"
				},
				new Station
				{
					Name = "Newhaven Town",
					Code = "NVN"
				},
				new Station
				{
					Name = "Newington",
					Code = "NGT"
				},
				new Station
				{
					Name = "Newmarket",
					Code = "NMK"
				},
				new Station
				{
					Name = "Newport (Essex)",
					Code = "NWE"
				},
				new Station
				{
					Name = "Newport (South Wales)",
					Code = "NWP"
				},
				new Station
				{
					Name = "Newquay",
					Code = "NQY"
				},
				new Station
				{
					Name = "Newstead",
					Code = "NSD"
				},
				new Station
				{
					Name = "Newton Abbot",
					Code = "NTA"
				},
				new Station
				{
					Name = "Newton Aycliffe",
					Code = "NAY"
				},
				new Station
				{
					Name = "Newton for Hyde",
					Code = "NWN"
				},
				new Station
				{
					Name = "Newton (Lanark)",
					Code = "NTN"
				},
				new Station
				{
					Name = "Newton St Cyres",
					Code = "NTC"
				},
				new Station
				{
					Name = "Newton-le-Willows",
					Code = "NLW"
				},
				new Station
				{
					Name = "Newtonmore",
					Code = "NWR"
				},
				new Station
				{
					Name = "Newton-on-Ayr",
					Code = "NOA"
				},
				new Station
				{
					Name = "Newtown (Powys)",
					Code = "NWT"
				},
				new Station
				{
					Name = "Ninian Park",
					Code = "NNP"
				},
				new Station
				{
					Name = "Nitshill",
					Code = "NIT"
				},
				new Station
				{
					Name = "Norbiton",
					Code = "NBT"
				},
				new Station
				{
					Name = "Norbury",
					Code = "NRB"
				},
				new Station
				{
					Name = "Normans Bay",
					Code = "NSB"
				},
				new Station
				{
					Name = "Normanton",
					Code = "NOR"
				},
				new Station
				{
					Name = "North Berwick",
					Code = "NBW"
				},
				new Station
				{
					Name = "North Camp",
					Code = "NCM"
				},
				new Station
				{
					Name = "North Dulwich",
					Code = "NDL"
				},
				new Station
				{
					Name = "North Fambridge",
					Code = "NFA"
				},
				new Station
				{
					Name = "North Llanrwst",
					Code = "NLR"
				},
				new Station
				{
					Name = "North Queensferry",
					Code = "NQU"
				},
				new Station
				{
					Name = "North Road (Darlington)",
					Code = "NRD"
				},
				new Station
				{
					Name = "North Sheen",
					Code = "NSH"
				},
				new Station
				{
					Name = "North Walsham",
					Code = "NWA"
				},
				new Station
				{
					Name = "North Wembley",
					Code = "NWB"
				},
				new Station
				{
					Name = "Northallerton",
					Code = "NTR"
				},
				new Station
				{
					Name = "Northampton",
					Code = "NMP"
				},
				new Station
				{
					Name = "Northfield",
					Code = "NFD"
				},
				new Station
				{
					Name = "Northfleet",
					Code = "NFL"
				},
				new Station
				{
					Name = "Northolt Park",
					Code = "NLT"
				},
				new Station
				{
					Name = "Northumberland Park",
					Code = "NUM"
				},
				new Station
				{
					Name = "Northwich",
					Code = "NWI"
				},
				new Station
				{
					Name = "Norton Bridge",
					Code = "NTB"
				},
				new Station
				{
					Name = "Norwich",
					Code = "NRW"
				},
				new Station
				{
					Name = "Norwood Junction",
					Code = "NWD"
				},
				new Station
				{
					Name = "Nottingham",
					Code = "NOT"
				},
				new Station
				{
					Name = "Nuneaton",
					Code = "NUN"
				},
				new Station
				{
					Name = "Nunhead",
					Code = "NHD"
				},
				new Station
				{
					Name = "Nunthorpe",
					Code = "NNT"
				},
				new Station
				{
					Name = "Nutbourne",
					Code = "NUT"
				},
				new Station
				{
					Name = "Nutfield",
					Code = "NUF"
				},
				new Station
				{
					Name = "Oakengates",
					Code = "OKN"
				},
				new Station
				{
					Name = "Oakham",
					Code = "OKM"
				},
				new Station
				{
					Name = "Oakleigh Park",
					Code = "OKL"
				},
				new Station
				{
					Name = "Oban",
					Code = "OBN"
				},
				new Station
				{
					Name = "Ockendon",
					Code = "OCK"
				},
				new Station
				{
					Name = "Ockley",
					Code = "OLY"
				},
				new Station
				{
					Name = "Okehampton",
					Code = "OKE"
				},
				new Station
				{
					Name = "Old Hill",
					Code = "OHL"
				},
				new Station
				{
					Name = "Old Roan",
					Code = "ORN"
				},
				new Station
				{
					Name = "Old Street",
					Code = "OLD"
				},
				new Station
				{
					Name = "Oldfield Park",
					Code = "OLF"
				},
				new Station
				{
					Name = "Olton",
					Code = "OLT"
				},
				new Station
				{
					Name = "Ore",
					Code = "ORE"
				},
				new Station
				{
					Name = "Ormskirk",
					Code = "OMS"
				},
				new Station
				{
					Name = "Orpington",
					Code = "ORP"
				},
				new Station
				{
					Name = "Orrell",
					Code = "ORR"
				},
				new Station
				{
					Name = "Orrell Park",
					Code = "OPK"
				},
				new Station
				{
					Name = "Otford",
					Code = "OTF"
				},
				new Station
				{
					Name = "Oulton Broad North",
					Code = "OUN"
				},
				new Station
				{
					Name = "Oulton Broad South",
					Code = "OUS"
				},
				new Station
				{
					Name = "Outwood",
					Code = "OUT"
				},
				new Station
				{
					Name = "Overpool",
					Code = "OVE"
				},
				new Station
				{
					Name = "Overton",
					Code = "OVR"
				},
				new Station
				{
					Name = "Oxenholme Lake District",
					Code = "OXN"
				},
				new Station
				{
					Name = "Oxford",
					Code = "OXF"
				},
				new Station
				{
					Name = "Oxshott",
					Code = "OXS"
				},
				new Station
				{
					Name = "Oxted",
					Code = "OXT"
				},
				new Station
				{
					Name = "Paddock Wood",
					Code = "PDW"
				},
				new Station
				{
					Name = "Padgate",
					Code = "PDG"
				},
				new Station
				{
					Name = "Paignton",
					Code = "PGN"
				},
				new Station
				{
					Name = "Paisley Canal",
					Code = "PCN"
				},
				new Station
				{
					Name = "Paisley Gilmour Street",
					Code = "PYG"
				},
				new Station
				{
					Name = "Paisley St James",
					Code = "PYJ"
				},
				new Station
				{
					Name = "Palmers Green",
					Code = "PAL"
				},
				new Station
				{
					Name = "Pangbourne",
					Code = "PAN"
				},
				new Station
				{
					Name = "Pannal",
					Code = "PNL"
				},
				new Station
				{
					Name = "Pantyffynnon",
					Code = "PTF"
				},
				new Station
				{
					Name = "Par",
					Code = "PAR"
				},
				new Station
				{
					Name = "Parbold",
					Code = "PBL"
				},
				new Station
				{
					Name = "Park Street",
					Code = "PKT"
				},
				new Station
				{
					Name = "Parkstone (Dorset)",
					Code = "PKS"
				},
				new Station
				{
					Name = "Parson Street",
					Code = "PSN"
				},
				new Station
				{
					Name = "Partick",
					Code = "PTK"
				},
				new Station
				{
					Name = "Parton",
					Code = "PRN"
				},
				new Station
				{
					Name = "Patchway",
					Code = "PWY"
				},
				new Station
				{
					Name = "Patricroft",
					Code = "PAT"
				},
				new Station
				{
					Name = "Patterton",
					Code = "PTT"
				},
				new Station
				{
					Name = "Peartree",
					Code = "PEA"
				},
				new Station
				{
					Name = "Peckham Rye",
					Code = "PMR"
				},
				new Station
				{
					Name = "Pegswood",
					Code = "PEG"
				},
				new Station
				{
					Name = "Pemberton",
					Code = "PEM"
				},
				new Station
				{
					Name = "Pembrey & Burry Port",
					Code = "PBY"
				},
				new Station
				{
					Name = "Pembroke",
					Code = "PMB"
				},
				new Station
				{
					Name = "Pembroke Dock",
					Code = "PMD"
				},
				new Station
				{
					Name = "Penally",
					Code = "PNA"
				},
				new Station
				{
					Name = "Penarth",
					Code = "PEN"
				},
				new Station
				{
					Name = "Pencoed",
					Code = "PCD"
				},
				new Station
				{
					Name = "Pengam",
					Code = "PGM"
				},
				new Station
				{
					Name = "Penge East",
					Code = "PNE"
				},
				new Station
				{
					Name = "Penge West",
					Code = "PNW"
				},
				new Station
				{
					Name = "Penhelig",
					Code = "PHG"
				},
				new Station
				{
					Name = "Penistone",
					Code = "PNS"
				},
				new Station
				{
					Name = "Penkridge",
					Code = "PKG"
				},
				new Station
				{
					Name = "Penmaenmawr",
					Code = "PMW"
				},
				new Station
				{
					Name = "Penmere",
					Code = "PNM"
				},
				new Station
				{
					Name = "Penrhiwceiber",
					Code = "PER"
				},
				new Station
				{
					Name = "Penrhyndeudraeth",
					Code = "PRH"
				},
				new Station
				{
					Name = "Penrith (North Lakes)",
					Code = "PNR"
				},
				new Station
				{
					Name = "Penryn (Cornwall)",
					Code = "PYN"
				},
				new Station
				{
					Name = "Pensarn (Gwynedd)",
					Code = "PES"
				},
				new Station
				{
					Name = "Penshurst",
					Code = "PHR"
				},
				new Station
				{
					Name = "Pentre-Bach",
					Code = "PTB"
				},
				new Station
				{
					Name = "Pen-y-Bont",
					Code = "PNY"
				},
				new Station
				{
					Name = "Penychain",
					Code = "PNC"
				},
				new Station
				{
					Name = "Penyffordd",
					Code = "PNF"
				},
				new Station
				{
					Name = "Penzance",
					Code = "PNZ"
				},
				new Station
				{
					Name = "Perranwell",
					Code = "PRW"
				},
				new Station
				{
					Name = "Perry Barr",
					Code = "PRY"
				},
				new Station
				{
					Name = "Pershore",
					Code = "PSH"
				},
				new Station
				{
					Name = "Perth",
					Code = "PTH"
				},
				new Station
				{
					Name = "Peterborough",
					Code = "PBO"
				},
				new Station
				{
					Name = "Petersfield",
					Code = "PTR"
				},
				new Station
				{
					Name = "Petts Wood",
					Code = "PET"
				},
				new Station
				{
					Name = "Pevensey & Westham",
					Code = "PEV"
				},
				new Station
				{
					Name = "Pevensey Bay",
					Code = "PEB"
				},
				new Station
				{
					Name = "Pewsey",
					Code = "PEW"
				},
				new Station
				{
					Name = "Pilning",
					Code = "PIL"
				},
				new Station
				{
					Name = "Pinhoe",
					Code = "PIN"
				},
				new Station
				{
					Name = "Pitlochry",
					Code = "PIT"
				},
				new Station
				{
					Name = "Pitsea",
					Code = "PSE"
				},
				new Station
				{
					Name = "Pleasington",
					Code = "PLS"
				},
				new Station
				{
					Name = "Plockton",
					Code = "PLK"
				},
				new Station
				{
					Name = "Pluckley",
					Code = "PLC"
				},
				new Station
				{
					Name = "Plumley",
					Code = "PLM"
				},
				new Station
				{
					Name = "Plumpton",
					Code = "PMP"
				},
				new Station
				{
					Name = "Plumstead",
					Code = "PLU"
				},
				new Station
				{
					Name = "Plymouth",
					Code = "PLY"
				},
				new Station
				{
					Name = "Pokesdown",
					Code = "POK"
				},
				new Station
				{
					Name = "Polegate",
					Code = "PLG"
				},
				new Station
				{
					Name = "Polesworth",
					Code = "PSW"
				},
				new Station
				{
					Name = "Pollokshaws East",
					Code = "PWE"
				},
				new Station
				{
					Name = "Pollokshaws West",
					Code = "PWW"
				},
				new Station
				{
					Name = "Pollokshields East",
					Code = "PLE"
				},
				new Station
				{
					Name = "Pollokshields West",
					Code = "PLW"
				},
				new Station
				{
					Name = "Polmont",
					Code = "PMT"
				},
				new Station
				{
					Name = "Polsloe Bridge",
					Code = "POL"
				},
				new Station
				{
					Name = "Ponders End",
					Code = "PON"
				},
				new Station
				{
					Name = "Pontarddulais",
					Code = "PTD"
				},
				new Station
				{
					Name = "Pontefract Baghill",
					Code = "PFR"
				},
				new Station
				{
					Name = "Pontefract Monkhill",
					Code = "PFM"
				},
				new Station
				{
					Name = "Pontefract Tanshelf",
					Code = "POT"
				},
				new Station
				{
					Name = "Pontlottyn",
					Code = "PLT"
				},
				new Station
				{
					Name = "Pontyclun",
					Code = "PYC"
				},
				new Station
				{
					Name = "Pont-y-Pant",
					Code = "PYP"
				},
				new Station
				{
					Name = "Pontypool & New Inn",
					Code = "PPL"
				},
				new Station
				{
					Name = "Pontypridd",
					Code = "PPD"
				},
				new Station
				{
					Name = "Poole",
					Code = "POO"
				},
				new Station
				{
					Name = "Poppleton",
					Code = "POP"
				},
				new Station
				{
					Name = "Port Glasgow",
					Code = "PTG"
				},
				new Station
				{
					Name = "Port Sunlight",
					Code = "PSL"
				},
				new Station
				{
					Name = "Port Talbot Parkway",
					Code = "PTA"
				},
				new Station
				{
					Name = "Portchester",
					Code = "PTC"
				},
				new Station
				{
					Name = "Porth",
					Code = "POR"
				},
				new Station
				{
					Name = "Porthmadog",
					Code = "PTM"
				},
				new Station
				{
					Name = "Portlethen",
					Code = "PLN"
				},
				new Station
				{
					Name = "Portslade",
					Code = "PLD"
				},
				new Station
				{
					Name = "Portsmouth & Southsea",
					Code = "PMS"
				},
				new Station
				{
					Name = "Portsmouth Arms",
					Code = "PMA"
				},
				new Station
				{
					Name = "Portsmouth Harbour",
					Code = "PMH"
				},
				new Station
				{
					Name = "Possilpark & Parkhouse",
					Code = "PPK"
				},
				new Station
				{
					Name = "Potters Bar",
					Code = "PBR"
				},
				new Station
				{
					Name = "Poulton-le-Fylde",
					Code = "PFY"
				},
				new Station
				{
					Name = "Poynton",
					Code = "PYT"
				},
				new Station
				{
					Name = "Prees",
					Code = "PRS"
				},
				new Station
				{
					Name = "Prescot",
					Code = "PSC"
				},
				new Station
				{
					Name = "Prestatyn",
					Code = "PRT"
				},
				new Station
				{
					Name = "Prestbury",
					Code = "PRB"
				},
				new Station
				{
					Name = "Preston (Lancs)",
					Code = "PRE"
				},
				new Station
				{
					Name = "Preston Park",
					Code = "PRP"
				},
				new Station
				{
					Name = "Prestonpans",
					Code = "PST"
				},
				new Station
				{
					Name = "Prestwick International Airport",
					Code = "PRA"
				},
				new Station
				{
					Name = "Prestwick Town",
					Code = "PTW"
				},
				new Station
				{
					Name = "Priesthill & Darnley",
					Code = "PTL"
				},
				new Station
				{
					Name = "Princes Risborough",
					Code = "PRR"
				},
				new Station
				{
					Name = "Prittlewell",
					Code = "PRL"
				},
				new Station
				{
					Name = "Prudhoe",
					Code = "PRU"
				},
				new Station
				{
					Name = "Pulborough",
					Code = "PUL"
				},
				new Station
				{
					Name = "Purfleet",
					Code = "PFL"
				},
				new Station
				{
					Name = "Purley",
					Code = "PUR"
				},
				new Station
				{
					Name = "Purley Oaks",
					Code = "PUO"
				},
				new Station
				{
					Name = "Putney",
					Code = "PUT"
				},
				new Station
				{
					Name = "Pwllheli",
					Code = "PWL"
				},
				new Station
				{
					Name = "Pyle",
					Code = "PYL"
				},
				new Station
				{
					Name = "Quakers Yard",
					Code = "QYD"
				},
				new Station
				{
					Name = "Queenborough",
					Code = "QBR"
				},
				new Station
				{
					Name = "Queens Park (Glasgow)",
					Code = "QPK"
				},
				new Station
				{
					Name = "Queens Park (London)",
					Code = "QPW"
				},
				new Station
				{
					Name = "Queens Road (Peckham)",
					Code = "QRP"
				},
				new Station
				{
					Name = "Queenstown Road (Battersea)",
					Code = "QRB"
				},
				new Station
				{
					Name = "Quintrell Downs",
					Code = "QUI"
				},
				new Station
				{
					Name = "Radcliffe-on-Trent",
					Code = "RDF"
				},
				new Station
				{
					Name = "Radlett",
					Code = "RDT"
				},
				new Station
				{
					Name = "Radley",
					Code = "RAD"
				},
				new Station
				{
					Name = "Radyr",
					Code = "RDR"
				},
				new Station
				{
					Name = "Rainford",
					Code = "RNF"
				},
				new Station
				{
					Name = "Rainham (Essex)",
					Code = "RNM"
				},
				new Station
				{
					Name = "Rainham (Kent)",
					Code = "RAI"
				},
				new Station
				{
					Name = "Rainhill",
					Code = "RNH"
				},
				new Station
				{
					Name = "Ramsgate",
					Code = "RAM"
				},
				new Station
				{
					Name = "Ramsgreave & Wilpshire",
					Code = "RGW"
				},
				new Station
				{
					Name = "Rannoch",
					Code = "RAN"
				},
				new Station
				{
					Name = "Rauceby",
					Code = "RAU"
				},
				new Station
				{
					Name = "Ravenglass for Eskdale",
					Code = "RAV"
				},
				new Station
				{
					Name = "Ravensbourne",
					Code = "RVB"
				},
				new Station
				{
					Name = "Ravensthorpe",
					Code = "RVN"
				},
				new Station
				{
					Name = "Rawcliffe",
					Code = "RWC"
				},
				new Station
				{
					Name = "Rayleigh",
					Code = "RLG"
				},
				new Station
				{
					Name = "Raynes Park",
					Code = "RAY"
				},
				new Station
				{
					Name = "Reading",
					Code = "RDG"
				},
				new Station
				{
					Name = "Reading West",
					Code = "RDW"
				},
				new Station
				{
					Name = "Rectory Road",
					Code = "REC"
				},
				new Station
				{
					Name = "Redbridge",
					Code = "RDB"
				},
				new Station
				{
					Name = "Redcar British Steel",
					Code = "RBS"
				},
				new Station
				{
					Name = "Redcar Central",
					Code = "RCC"
				},
				new Station
				{
					Name = "Redcar East",
					Code = "RCE"
				},
				new Station
				{
					Name = "Reddish North",
					Code = "RDN"
				},
				new Station
				{
					Name = "Reddish South",
					Code = "RDS"
				},
				new Station
				{
					Name = "Redditch",
					Code = "RDC"
				},
				new Station
				{
					Name = "Redhill",
					Code = "RDH"
				},
				new Station
				{
					Name = "Redland",
					Code = "RDA"
				},
				new Station
				{
					Name = "Redruth",
					Code = "RED"
				},
				new Station
				{
					Name = "Reedham (Norfolk)",
					Code = "REE"
				},
				new Station
				{
					Name = "Reedham (Surrey)",
					Code = "RHM"
				},
				new Station
				{
					Name = "Reigate",
					Code = "REI"
				},
				new Station
				{
					Name = "Renton",
					Code = "RTN"
				},
				new Station
				{
					Name = "Retford",
					Code = "RET"
				},
				new Station
				{
					Name = "Rhiwbina",
					Code = "RHI"
				},
				new Station
				{
					Name = "Rhoose Cardiff International Airport",
					Code = "RIA"
				},
				new Station
				{
					Name = "Rhosneigr",
					Code = "RHO"
				},
				new Station
				{
					Name = "Rhyl",
					Code = "RHL"
				},
				new Station
				{
					Name = "Rhymney",
					Code = "RHY"
				},
				new Station
				{
					Name = "Ribblehead",
					Code = "RHD"
				},
				new Station
				{
					Name = "Rice Lane",
					Code = "RIL"
				},
				new Station
				{
					Name = "Richmond (London)",
					Code = "RMD"
				},
				new Station
				{
					Name = "Rickmansworth",
					Code = "RIC"
				},
				new Station
				{
					Name = "Riddlesdown",
					Code = "RDD"
				},
				new Station
				{
					Name = "Ridgmont",
					Code = "RID"
				},
				new Station
				{
					Name = "Riding Mill",
					Code = "RDM"
				},
				new Station
				{
					Name = "Risca & Pontymister",
					Code = "RCA"
				},
				new Station
				{
					Name = "Rishton",
					Code = "RIS"
				},
				new Station
				{
					Name = "Robertsbridge",
					Code = "RBR"
				},
				new Station
				{
					Name = "Roby",
					Code = "ROB"
				},
				new Station
				{
					Name = "Rochdale",
					Code = "RCD"
				},
				new Station
				{
					Name = "Roche",
					Code = "ROC"
				},
				new Station
				{
					Name = "Rochester",
					Code = "RTR"
				},
				new Station
				{
					Name = "Rochford",
					Code = "RFD"
				},
				new Station
				{
					Name = "Rock Ferry",
					Code = "RFY"
				},
				new Station
				{
					Name = "Rogart",
					Code = "ROG"
				},
				new Station
				{
					Name = "Rogerstone",
					Code = "ROR"
				},
				new Station
				{
					Name = "Rolleston",
					Code = "ROL"
				},
				new Station
				{
					Name = "Roman Bridge",
					Code = "RMB"
				},
				new Station
				{
					Name = "Romford",
					Code = "RMF"
				},
				new Station
				{
					Name = "Romiley",
					Code = "RML"
				},
				new Station
				{
					Name = "Romsey",
					Code = "ROM"
				},
				new Station
				{
					Name = "Roose",
					Code = "ROO"
				},
				new Station
				{
					Name = "Rose Grove",
					Code = "RSG"
				},
				new Station
				{
					Name = "Rose Hill Marple",
					Code = "RSH"
				},
				new Station
				{
					Name = "Rosyth",
					Code = "ROS"
				},
				new Station
				{
					Name = "Rotherham Central",
					Code = "RMC"
				},
				new Station
				{
					Name = "Rotherhithe",
					Code = "ROE"
				},
				new Station
				{
					Name = "Roughton Road",
					Code = "RNR"
				},
				new Station
				{
					Name = "Rowlands Castle",
					Code = "RLN"
				},
				new Station
				{
					Name = "Rowley Regis",
					Code = "ROW"
				},
				new Station
				{
					Name = "Roy Bridge",
					Code = "RYB"
				},
				new Station
				{
					Name = "Roydon",
					Code = "RYN"
				},
				new Station
				{
					Name = "Royston",
					Code = "RYS"
				},
				new Station
				{
					Name = "Ruabon",
					Code = "RUA"
				},
				new Station
				{
					Name = "Rufford",
					Code = "RUF"
				},
				new Station
				{
					Name = "Rugby",
					Code = "RUG"
				},
				new Station
				{
					Name = "Rugeley Town",
					Code = "RGT"
				},
				new Station
				{
					Name = "Rugeley Trent Valley",
					Code = "RGL"
				},
				new Station
				{
					Name = "Runcorn",
					Code = "RUN"
				},
				new Station
				{
					Name = "Runcorn East",
					Code = "RUE"
				},
				new Station
				{
					Name = "Ruskington",
					Code = "RKT"
				},
				new Station
				{
					Name = "Ruswarp",
					Code = "RUS"
				},
				new Station
				{
					Name = "Rutherglen",
					Code = "RUT"
				},
				new Station
				{
					Name = "Ryde St Johns Road",
					Code = "RYR"
				},
				new Station
				{
					Name = "Ryde Esplanade",
					Code = "RYD"
				},
				new Station
				{
					Name = "Ryde Pier Head",
					Code = "RYP"
				},
				new Station
				{
					Name = "Ryder Brow",
					Code = "RRB"
				},
				new Station
				{
					Name = "Rye House",
					Code = "RYH"
				},
				new Station
				{
					Name = "Rye (Sussex)",
					Code = "RYE"
				},
				new Station
				{
					Name = "Salford Central",
					Code = "SFD"
				},
				new Station
				{
					Name = "Salford Crescent",
					Code = "SLD"
				},
				new Station
				{
					Name = "Salfords (Surrey)",
					Code = "SAF"
				},
				new Station
				{
					Name = "Salhouse",
					Code = "SAH"
				},
				new Station
				{
					Name = "Salisbury",
					Code = "SAL"
				},
				new Station
				{
					Name = "Saltaire",
					Code = "SAE"
				},
				new Station
				{
					Name = "Saltash",
					Code = "STS"
				},
				new Station
				{
					Name = "Saltburn",
					Code = "SLB"
				},
				new Station
				{
					Name = "Saltcoats",
					Code = "SLT"
				},
				new Station
				{
					Name = "Saltmarshe",
					Code = "SAM"
				},
				new Station
				{
					Name = "Salwick",
					Code = "SLW"
				},
				new Station
				{
					Name = "Sampford Courtenay",
					Code = "SMC"
				},
				new Station
				{
					Name = "Sandal & Agbrigg",
					Code = "SNA"
				},
				new Station
				{
					Name = "Sandbach",
					Code = "SDB"
				},
				new Station
				{
					Name = "Sanderstead",
					Code = "SNR"
				},
				new Station
				{
					Name = "Sandhills",
					Code = "SDL"
				},
				new Station
				{
					Name = "Sandhurst (Berks)",
					Code = "SND"
				},
				new Station
				{
					Name = "Sandling",
					Code = "SDG"
				},
				new Station
				{
					Name = "Sandown",
					Code = "SAN"
				},
				new Station
				{
					Name = "Sandplace",
					Code = "SDP"
				},
				new Station
				{
					Name = "Sandwell & Dudley",
					Code = "SAD"
				},
				new Station
				{
					Name = "Sandwich",
					Code = "SDW"
				},
				new Station
				{
					Name = "Sandy",
					Code = "SDY"
				},
				new Station
				{
					Name = "Sankey for Penketh",
					Code = "SNK"
				},
				new Station
				{
					Name = "Sanquhar",
					Code = "SQH"
				},
				new Station
				{
					Name = "Sarn",
					Code = "SRR"
				},
				new Station
				{
					Name = "Saundersfoot",
					Code = "SDF"
				},
				new Station
				{
					Name = "Saunderton",
					Code = "SDR"
				},
				new Station
				{
					Name = "Sawbridgeworth",
					Code = "SAW"
				},
				new Station
				{
					Name = "Saxilby",
					Code = "SXY"
				},
				new Station
				{
					Name = "Saxmundham",
					Code = "SAX"
				},
				new Station
				{
					Name = "Scarborough",
					Code = "SCA"
				},
				new Station
				{
					Name = "Scotscalder",
					Code = "SCT"
				},
				new Station
				{
					Name = "Scotstounhill",
					Code = "SCH"
				},
				new Station
				{
					Name = "Scunthorpe",
					Code = "SCU"
				},
				new Station
				{
					Name = "Sea Mills",
					Code = "SML"
				},
				new Station
				{
					Name = "Seaford (Sussex)",
					Code = "SEF"
				},
				new Station
				{
					Name = "Seaforth & Litherland",
					Code = "SFL"
				},
				new Station
				{
					Name = "Seaham",
					Code = "SEA"
				},
				new Station
				{
					Name = "Seamer",
					Code = "SEM"
				},
				new Station
				{
					Name = "Seascale",
					Code = "SSC"
				},
				new Station
				{
					Name = "Seaton Carew",
					Code = "SEC"
				},
				new Station
				{
					Name = "Seer Green & Jordans",
					Code = "SRG"
				},
				new Station
				{
					Name = "Selby",
					Code = "SBY"
				},
				new Station
				{
					Name = "Selhurst",
					Code = "SRS"
				},
				new Station
				{
					Name = "Sellafield",
					Code = "SEL"
				},
				new Station
				{
					Name = "Selling",
					Code = "SEG"
				},
				new Station
				{
					Name = "Selly Oak",
					Code = "SLY"
				},
				new Station
				{
					Name = "Settle",
					Code = "SET"
				},
				new Station
				{
					Name = "Seven Kings",
					Code = "SVK"
				},
				new Station
				{
					Name = "Seven Sisters",
					Code = "SVS"
				},
				new Station
				{
					Name = "Sevenoaks",
					Code = "SEV"
				},
				new Station
				{
					Name = "Severn Beach",
					Code = "SVB"
				},
				new Station
				{
					Name = "Severn Tunnel Junction",
					Code = "STJ"
				},
				new Station
				{
					Name = "Shadwell",
					Code = "SDE"
				},
				new Station
				{
					Name = "Shalford (Surrey)",
					Code = "SFR"
				},
				new Station
				{
					Name = "Shanklin",
					Code = "SHN"
				},
				new Station
				{
					Name = "Shawford",
					Code = "SHW"
				},
				new Station
				{
					Name = "Shawlands",
					Code = "SHL"
				},
				new Station
				{
					Name = "Sheerness-on-Sea",
					Code = "SSS"
				},
				new Station
				{
					Name = "Sheffield",
					Code = "SHF"
				},
				new Station
				{
					Name = "Shelford (Cambs)",
					Code = "SED"
				},
				new Station
				{
					Name = "Shenfield",
					Code = "SNF"
				},
				new Station
				{
					Name = "Shenstone",
					Code = "SEN"
				},
				new Station
				{
					Name = "Shepherd's Bush",
					Code = "SPB"
				},
				new Station
				{
					Name = "Shepherds Well",
					Code = "SPH"
				},
				new Station
				{
					Name = "Shepley",
					Code = "SPY"
				},
				new Station
				{
					Name = "Shepperton",
					Code = "SHP"
				},
				new Station
				{
					Name = "Shepreth",
					Code = "STH"
				},
				new Station
				{
					Name = "Sherborne",
					Code = "SHE"
				},
				new Station
				{
					Name = "Sherburn-in-Elmet",
					Code = "SIE"
				},
				new Station
				{
					Name = "Sheringham",
					Code = "SHM"
				},
				new Station
				{
					Name = "Shettleston",
					Code = "SLS"
				},
				new Station
				{
					Name = "Shieldmuir",
					Code = "SDM"
				},
				new Station
				{
					Name = "Shifnal",
					Code = "SFN"
				},
				new Station
				{
					Name = "Shildon",
					Code = "SHD"
				},
				new Station
				{
					Name = "Shiplake",
					Code = "SHI"
				},
				new Station
				{
					Name = "Shipley (Yorks)",
					Code = "SHY"
				},
				new Station
				{
					Name = "Shippea Hill",
					Code = "SPP"
				},
				new Station
				{
					Name = "Shipton",
					Code = "SIP"
				},
				new Station
				{
					Name = "Shirebrook",
					Code = "SHB"
				},
				new Station
				{
					Name = "Shirehampton",
					Code = "SHH"
				},
				new Station
				{
					Name = "Shireoaks",
					Code = "SRO"
				},
				new Station
				{
					Name = "Shirley",
					Code = "SRL"
				},
				new Station
				{
					Name = "Shoeburyness",
					Code = "SRY"
				},
				new Station
				{
					Name = "Sholing",
					Code = "SHO"
				},
				new Station
				{
					Name = "Shoreditch High Street",
					Code = "SDC"
				},
				new Station
				{
					Name = "Shoreham (Kent)",
					Code = "SEH"
				},
				new Station
				{
					Name = "Shoreham-by-Sea",
					Code = "SSE"
				},
				new Station
				{
					Name = "Shortlands",
					Code = "SRT"
				},
				new Station
				{
					Name = "Shotton",
					Code = "SHT"
				},
				new Station
				{
					Name = "Shotts",
					Code = "SHS"
				},
				new Station
				{
					Name = "Shrewsbury",
					Code = "SHR"
				},
				new Station
				{
					Name = "Sidcup",
					Code = "SID"
				},
				new Station
				{
					Name = "Sileby",
					Code = "SIL"
				},
				new Station
				{
					Name = "Silecroft",
					Code = "SIC"
				},
				new Station
				{
					Name = "Silkstone Common",
					Code = "SLK"
				},
				new Station
				{
					Name = "Silver Street",
					Code = "SLV"
				},
				new Station
				{
					Name = "Silverdale",
					Code = "SVR"
				},
				new Station
				{
					Name = "Singer",
					Code = "SIN"
				},
				new Station
				{
					Name = "Sittingbourne",
					Code = "SIT"
				},
				new Station
				{
					Name = "Skegness",
					Code = "SKG"
				},
				new Station
				{
					Name = "Skewen",
					Code = "SKE"
				},
				new Station
				{
					Name = "Skipton",
					Code = "SKI"
				},
				new Station
				{
					Name = "Slade Green",
					Code = "SGR"
				},
				new Station
				{
					Name = "Slaithwaite",
					Code = "SWT"
				},
				new Station
				{
					Name = "Slateford",
					Code = "SLA"
				},
				new Station
				{
					Name = "Sleaford",
					Code = "SLR"
				},
				new Station
				{
					Name = "Sleights",
					Code = "SLH"
				},
				new Station
				{
					Name = "Slough",
					Code = "SLO"
				},
				new Station
				{
					Name = "Small Heath",
					Code = "SMA"
				},
				new Station
				{
					Name = "Smallbrook Junction",
					Code = "SAB"
				},
				new Station
				{
					Name = "Smethwick Galton Bridge",
					Code = "SGB"
				},
				new Station
				{
					Name = "Smethwick Rolfe Street",
					Code = "SMR"
				},
				new Station
				{
					Name = "Smithy Bridge",
					Code = "SMB"
				},
				new Station
				{
					Name = "Snaith",
					Code = "SNI"
				},
				new Station
				{
					Name = "Snodland",
					Code = "SDA"
				},
				new Station
				{
					Name = "Snowdown",
					Code = "SWO"
				},
				new Station
				{
					Name = "Sole Street",
					Code = "SOR"
				},
				new Station
				{
					Name = "Solihull",
					Code = "SOL"
				},
				new Station
				{
					Name = "Somerleyton",
					Code = "SYT"
				},
				new Station
				{
					Name = "South Acton",
					Code = "SAT"
				},
				new Station
				{
					Name = "South Bank",
					Code = "SBK"
				},
				new Station
				{
					Name = "South Bermondsey",
					Code = "SBM"
				},
				new Station
				{
					Name = "South Croydon",
					Code = "SCY"
				},
				new Station
				{
					Name = "South Elmsall",
					Code = "SES"
				},
				new Station
				{
					Name = "South Greenford",
					Code = "SGN"
				},
				new Station
				{
					Name = "South Gyle",
					Code = "SGL"
				},
				new Station
				{
					Name = "South Hampstead",
					Code = "SOH"
				},
				new Station
				{
					Name = "South Kenton",
					Code = "SOK"
				},
				new Station
				{
					Name = "South Merton",
					Code = "SMO"
				},
				new Station
				{
					Name = "South Milford",
					Code = "SOM"
				},
				new Station
				{
					Name = "South Ruislip",
					Code = "SRU"
				},
				new Station
				{
					Name = "South Tottenham",
					Code = "STO"
				},
				new Station
				{
					Name = "South Wigston",
					Code = "SWS"
				},
				new Station
				{
					Name = "South Woodham Ferrers",
					Code = "SOF"
				},
				new Station
				{
					Name = "Southall",
					Code = "STL"
				},
				new Station
				{
					Name = "Southampton Airport Parkway",
					Code = "SOA"
				},
				new Station
				{
					Name = "Southampton Central",
					Code = "SOU"
				},
				new Station
				{
					Name = "Southbourne",
					Code = "SOB"
				},
				new Station
				{
					Name = "Southbury",
					Code = "SBU"
				},
				new Station
				{
					Name = "Southease",
					Code = "SEE"
				},
				new Station
				{
					Name = "Southend Airport",
					Code = "SIA"
				},
				new Station
				{
					Name = "Southend Central",
					Code = "SOC"
				},
				new Station
				{
					Name = "Southend East",
					Code = "SOE"
				},
				new Station
				{
					Name = "Southend Victoria",
					Code = "SOV"
				},
				new Station
				{
					Name = "Southminster",
					Code = "SMN"
				},
				new Station
				{
					Name = "Southport",
					Code = "SOP"
				},
				new Station
				{
					Name = "Southwick",
					Code = "SWK"
				},
				new Station
				{
					Name = "Sowerby Bridge",
					Code = "SOW"
				},
				new Station
				{
					Name = "Spalding",
					Code = "SPA"
				},
				new Station
				{
					Name = "Spean Bridge",
					Code = "SBR"
				},
				new Station
				{
					Name = "Spital",
					Code = "SPI"
				},
				new Station
				{
					Name = "Spondon",
					Code = "SPO"
				},
				new Station
				{
					Name = "Spooner Row",
					Code = "SPN"
				},
				new Station
				{
					Name = "Spring Road",
					Code = "SRI"
				},
				new Station
				{
					Name = "Springburn",
					Code = "SPR"
				},
				new Station
				{
					Name = "Springfield",
					Code = "SPF"
				},
				new Station
				{
					Name = "Squires Gate",
					Code = "SQU"
				},
				new Station
				{
					Name = "St Albans",
					Code = "SAC"
				},
				new Station
				{
					Name = "St Albans Abbey",
					Code = "SAA"
				},
				new Station
				{
					Name = "St Andrews Road",
					Code = "SAR"
				},
				new Station
				{
					Name = "St Annes-on-Sea",
					Code = "SAS"
				},
				new Station
				{
					Name = "St Austell",
					Code = "SAU"
				},
				new Station
				{
					Name = "St Bees",
					Code = "SBS"
				},
				new Station
				{
					Name = "St Budeaux Ferry Road",
					Code = "SBF"
				},
				new Station
				{
					Name = "St Budeaux Victoria Road",
					Code = "SBV"
				},
				new Station
				{
					Name = "St Columb Road",
					Code = "SCR"
				},
				new Station
				{
					Name = "St Denys",
					Code = "SDN"
				},
				new Station
				{
					Name = "St Erth",
					Code = "SER"
				},
				new Station
				{
					Name = "St Germans",
					Code = "SGM"
				},
				new Station
				{
					Name = "St Helens Central",
					Code = "SNH"
				},
				new Station
				{
					Name = "St Helens Junction",
					Code = "SHJ"
				},
				new Station
				{
					Name = "St Helier (Surrey)",
					Code = "SIH"
				},
				new Station
				{
					Name = "St Ives (Cornwall)",
					Code = "SIV"
				},
				new Station
				{
					Name = "St James Park (Exeter)",
					Code = "SJP"
				},
				new Station
				{
					Name = "St James Street (Walthamstow)",
					Code = "SJS"
				},
				new Station
				{
					Name = "St Johns (London)",
					Code = "SAJ"
				},
				new Station
				{
					Name = "St Keyne Wishing Well Halt",
					Code = "SKN"
				},
				new Station
				{
					Name = "St Leonards Warrior Square",
					Code = "SLQ"
				},
				new Station
				{
					Name = "St Margarets (Herts)",
					Code = "SMT"
				},
				new Station
				{
					Name = "St Margarets (London)",
					Code = "SMG"
				},
				new Station
				{
					Name = "St Mary Cray",
					Code = "SMY"
				},
				new Station
				{
					Name = "St Michaels",
					Code = "STM"
				},
				new Station
				{
					Name = "St Neots",
					Code = "SNO"
				},
				new Station
				{
					Name = "Stafford",
					Code = "STA"
				},
				new Station
				{
					Name = "Staines",
					Code = "SNS"
				},
				new Station
				{
					Name = "Stallingborough",
					Code = "SLL"
				},
				new Station
				{
					Name = "Stalybridge",
					Code = "SYB"
				},
				new Station
				{
					Name = "Stamford Hill",
					Code = "SMH"
				},
				new Station
				{
					Name = "Stamford (Lincs)",
					Code = "SMD"
				},
				new Station
				{
					Name = "Stanford-le-Hope",
					Code = "SFO"
				},
				new Station
				{
					Name = "Stanlow & Thornton",
					Code = "SNT"
				},
				new Station
				{
					Name = "Stansted Airport",
					Code = "SSD"
				},
				new Station
				{
					Name = "Stansted Mountfitchet",
					Code = "SST"
				},
				new Station
				{
					Name = "Staplehurst",
					Code = "SPU"
				},
				new Station
				{
					Name = "Stapleton Road",
					Code = "SRD"
				},
				new Station
				{
					Name = "Starbeck",
					Code = "SBE"
				},
				new Station
				{
					Name = "Starcross",
					Code = "SCS"
				},
				new Station
				{
					Name = "Staveley (Cumbria)",
					Code = "SVL"
				},
				new Station
				{
					Name = "Stechford",
					Code = "SCF"
				},
				new Station
				{
					Name = "Steeton & Silsden",
					Code = "SON"
				},
				new Station
				{
					Name = "Stepps",
					Code = "SPS"
				},
				new Station
				{
					Name = "Stevenage",
					Code = "SVG"
				},
				new Station
				{
					Name = "Stevenston",
					Code = "STV"
				},
				new Station
				{
					Name = "Stewartby",
					Code = "SWR"
				},
				new Station
				{
					Name = "Stewarton",
					Code = "STT"
				},
				new Station
				{
					Name = "Stirling",
					Code = "STG"
				},
				new Station
				{
					Name = "Stockport",
					Code = "SPT"
				},
				new Station
				{
					Name = "Stocksfield",
					Code = "SKS"
				},
				new Station
				{
					Name = "Stocksmoor",
					Code = "SSM"
				},
				new Station
				{
					Name = "Stockton",
					Code = "STK"
				},
				new Station
				{
					Name = "Stoke Mandeville",
					Code = "SKM"
				},
				new Station
				{
					Name = "Stoke Newington",
					Code = "SKW"
				},
				new Station
				{
					Name = "Stoke-on-Trent",
					Code = "SOT"
				},
				new Station
				{
					Name = "Stone Crossing",
					Code = "SCG"
				},
				new Station
				{
					Name = "Stone (Staffs)",
					Code = "SNE"
				},
				new Station
				{
					Name = "Stonebridge Park",
					Code = "SBP"
				},
				new Station
				{
					Name = "Stonegate",
					Code = "SOG"
				},
				new Station
				{
					Name = "Stonehaven",
					Code = "STN"
				},
				new Station
				{
					Name = "Stonehouse",
					Code = "SHU"
				},
				new Station
				{
					Name = "Stoneleigh",
					Code = "SNL"
				},
				new Station
				{
					Name = "Stourbridge Junction",
					Code = "SBJ"
				},
				new Station
				{
					Name = "Stourbridge Town",
					Code = "SBT"
				},
				new Station
				{
					Name = "Stowmarket",
					Code = "SMK"
				},
				new Station
				{
					Name = "Stranraer",
					Code = "STR"
				},
				new Station
				{
					Name = "Stratford International",
					Code = "SFA"
				},
				new Station
				{
					Name = "Stratford (London)",
					Code = "SRA"
				},
				new Station
				{
					Name = "Stratford-upon-Avon",
					Code = "SAV"
				},
				new Station
				{
					Name = "Stratford-upon-Avon Parkway",
					Code = "STY"
				},
				new Station
				{
					Name = "Strathcarron",
					Code = "STC"
				},
				new Station
				{
					Name = "Strawberry Hill",
					Code = "STW"
				},
				new Station
				{
					Name = "Streatham Common",
					Code = "SRC"
				},
				new Station
				{
					Name = "Streatham Hill",
					Code = "SRH"
				},
				new Station
				{
					Name = "Streatham(Greater London)",
					Code = "STE"
				},
				new Station
				{
					Name = "Streethouse",
					Code = "SHC"
				},
				new Station
				{
					Name = "Strines",
					Code = "SRN"
				},
				new Station
				{
					Name = "Stromeferry",
					Code = "STF"
				},
				new Station
				{
					Name = "Strood (Kent)",
					Code = "SOO"
				},
				new Station
				{
					Name = "Stroud (Gloucs)",
					Code = "STD"
				},
				new Station
				{
					Name = "Sturry",
					Code = "STU"
				},
				new Station
				{
					Name = "Styal",
					Code = "SYA"
				},
				new Station
				{
					Name = "Sudbury & Harrow Road",
					Code = "SUD"
				},
				new Station
				{
					Name = "Sudbury Hill Harrow",
					Code = "SDH"
				},
				new Station
				{
					Name = "Sudbury (Suffolk)",
					Code = "SUY"
				},
				new Station
				{
					Name = "Sugar Loaf",
					Code = "SUG"
				},
				new Station
				{
					Name = "Summerston",
					Code = "SUM"
				},
				new Station
				{
					Name = "Sunbury",
					Code = "SUU"
				},
				new Station
				{
					Name = "Sunderland",
					Code = "SUN"
				},
				new Station
				{
					Name = "Sundridge Park",
					Code = "SUP"
				},
				new Station
				{
					Name = "Sunningdale",
					Code = "SNG"
				},
				new Station
				{
					Name = "Sunnymeads",
					Code = "SNY"
				},
				new Station
				{
					Name = "Surbiton",
					Code = "SUR"
				},
				new Station
				{
					Name = "Surrey Quays",
					Code = "SQE"
				},
				new Station
				{
					Name = "Sutton Coldfield",
					Code = "SUT"
				},
				new Station
				{
					Name = "Sutton Common",
					Code = "SUC"
				},
				new Station
				{
					Name = "Sutton Parkway",
					Code = "SPK"
				},
				new Station
				{
					Name = "Sutton (Surrey)",
					Code = "SUO"
				},
				new Station
				{
					Name = "Swale",
					Code = "SWL"
				},
				new Station
				{
					Name = "Swanley",
					Code = "SAY"
				},
				new Station
				{
					Name = "Swanscombe",
					Code = "SWM"
				},
				new Station
				{
					Name = "Swansea",
					Code = "SWA"
				},
				new Station
				{
					Name = "Swanwick",
					Code = "SNW"
				},
				new Station
				{
					Name = "Sway",
					Code = "SWY"
				},
				new Station
				{
					Name = "Swaythling",
					Code = "SWG"
				},
				new Station
				{
					Name = "Swinderby",
					Code = "SWD"
				},
				new Station
				{
					Name = "Swindon (Wilts)",
					Code = "SWI"
				},
				new Station
				{
					Name = "Swineshead",
					Code = "SWE"
				},
				new Station
				{
					Name = "Swinton (Manchester)",
					Code = "SNN"
				},
				new Station
				{
					Name = "Swinton (South Yorks)",
					Code = "SWN"
				},
				new Station
				{
					Name = "Sydenham Hill",
					Code = "SYH"
				},
				new Station
				{
					Name = "Sydenham (London)",
					Code = "SYD"
				},
				new Station
				{
					Name = "Syon Lane",
					Code = "SYL"
				},
				new Station
				{
					Name = "Syston",
					Code = "SYS"
				},
				new Station
				{
					Name = "Tackley",
					Code = "TAC"
				},
				new Station
				{
					Name = "Tadworth",
					Code = "TAD"
				},
				new Station
				{
					Name = "Taffs Well",
					Code = "TAF"
				},
				new Station
				{
					Name = "Tain",
					Code = "TAI"
				},
				new Station
				{
					Name = "Talsarnau",
					Code = "TAL"
				},
				new Station
				{
					Name = "Talybont",
					Code = "TLB"
				},
				new Station
				{
					Name = "Tal-y-Cafn",
					Code = "TLC"
				},
				new Station
				{
					Name = "Tame Bridge Parkway",
					Code = "TAB"
				},
				new Station
				{
					Name = "Tamworth",
					Code = "TAM"
				},
				new Station
				{
					Name = "Taplow",
					Code = "TAP"
				},
				new Station
				{
					Name = "Tattenham Corner",
					Code = "TAT"
				},
				new Station
				{
					Name = "Taunton",
					Code = "TAU"
				},
				new Station
				{
					Name = "Taynuilt",
					Code = "TAY"
				},
				new Station
				{
					Name = "Teddington",
					Code = "TED"
				},
				new Station
				{
					Name = "Tees-side Airport",
					Code = "TEA"
				},
				new Station
				{
					Name = "Teignmouth",
					Code = "TGM"
				},
				new Station
				{
					Name = "Telford Central",
					Code = "TFC"
				},
				new Station
				{
					Name = "Templecombe",
					Code = "TMC"
				},
				new Station
				{
					Name = "Tenby",
					Code = "TEN"
				},
				new Station
				{
					Name = "Teynham",
					Code = "TEY"
				},
				new Station
				{
					Name = "Thames Ditton",
					Code = "THD"
				},
				new Station
				{
					Name = "Thatcham",
					Code = "THA"
				},
				new Station
				{
					Name = "Thatto Heath",
					Code = "THH"
				},
				new Station
				{
					Name = "The Hawthorns",
					Code = "THW"
				},
				new Station
				{
					Name = "The Lakes (Warks)",
					Code = "TLK"
				},
				new Station
				{
					Name = "Theale",
					Code = "THE"
				},
				new Station
				{
					Name = "Theobalds Grove",
					Code = "TEO"
				},
				new Station
				{
					Name = "Thetford",
					Code = "TTF"
				},
				new Station
				{
					Name = "Thirsk",
					Code = "THI"
				},
				new Station
				{
					Name = "Thornaby",
					Code = "TBY"
				},
				new Station
				{
					Name = "Thorne North",
					Code = "TNN"
				},
				new Station
				{
					Name = "Thorne South",
					Code = "TNS"
				},
				new Station
				{
					Name = "Thornford",
					Code = "THO"
				},
				new Station
				{
					Name = "Thornliebank",
					Code = "THB"
				},
				new Station
				{
					Name = "Thornton Abbey",
					Code = "TNA"
				},
				new Station
				{
					Name = "Thornton Heath",
					Code = "TTH"
				},
				new Station
				{
					Name = "Thorntonhall",
					Code = "THT"
				},
				new Station
				{
					Name = "Thorpe Bay",
					Code = "TPB"
				},
				new Station
				{
					Name = "Thorpe Culvert",
					Code = "TPC"
				},
				new Station
				{
					Name = "Thorpe-le-Soken",
					Code = "TLS"
				},
				new Station
				{
					Name = "Three Bridges",
					Code = "TBD"
				},
				new Station
				{
					Name = "Three Oaks",
					Code = "TOK"
				},
				new Station
				{
					Name = "Thurgarton",
					Code = "THU"
				},
				new Station
				{
					Name = "Thurnscoe",
					Code = "THC"
				},
				new Station
				{
					Name = "Thurso",
					Code = "THS"
				},
				new Station
				{
					Name = "Thurston",
					Code = "TRS"
				},
				new Station
				{
					Name = "Tilbury Town",
					Code = "TIL"
				},
				new Station
				{
					Name = "Tile Hill",
					Code = "THL"
				},
				new Station
				{
					Name = "Tilehurst",
					Code = "TLH"
				},
				new Station
				{
					Name = "Tipton",
					Code = "TIP"
				},
				new Station
				{
					Name = "Tir-Phil",
					Code = "TIR"
				},
				new Station
				{
					Name = "Tisbury",
					Code = "TIS"
				},
				new Station
				{
					Name = "Tiverton Parkway",
					Code = "TVP"
				},
				new Station
				{
					Name = "Todmorden",
					Code = "TOD"
				},
				new Station
				{
					Name = "Tolworth",
					Code = "TOL"
				},
				new Station
				{
					Name = "Ton Pentre",
					Code = "TPN"
				},
				new Station
				{
					Name = "Tonbridge",
					Code = "TON"
				},
				new Station
				{
					Name = "Tondu",
					Code = "TDU"
				},
				new Station
				{
					Name = "Tonfanau",
					Code = "TNF"
				},
				new Station
				{
					Name = "Tonypandy",
					Code = "TNP"
				},
				new Station
				{
					Name = "Tooting",
					Code = "TOO"
				},
				new Station
				{
					Name = "Topsham",
					Code = "TOP"
				},
				new Station
				{
					Name = "Torquay",
					Code = "TQY"
				},
				new Station
				{
					Name = "Torre",
					Code = "TRR"
				},
				new Station
				{
					Name = "Totnes",
					Code = "TOT"
				},
				new Station
				{
					Name = "Tottenham Hale",
					Code = "TOM"
				},
				new Station
				{
					Name = "Totton",
					Code = "TTN"
				},
				new Station
				{
					Name = "Town Green",
					Code = "TWN"
				},
				new Station
				{
					Name = "Trafford Park",
					Code = "TRA"
				},
				new Station
				{
					Name = "Trefforest",
					Code = "TRF"
				},
				new Station
				{
					Name = "Trefforest Estate",
					Code = "TRE"
				},
				new Station
				{
					Name = "Trehafod",
					Code = "TRH"
				},
				new Station
				{
					Name = "Treherbert",
					Code = "TRB"
				},
				new Station
				{
					Name = "Treorchy",
					Code = "TRY"
				},
				new Station
				{
					Name = "Trimley",
					Code = "TRM"
				},
				new Station
				{
					Name = "Tring",
					Code = "TRI"
				},
				new Station
				{
					Name = "Troed-y-rhiw",
					Code = "TRD"
				},
				new Station
				{
					Name = "Troon",
					Code = "TRN"
				},
				new Station
				{
					Name = "Trowbridge",
					Code = "TRO"
				},
				new Station
				{
					Name = "Truro",
					Code = "TRU"
				},
				new Station
				{
					Name = "Tulloch",
					Code = "TUL"
				},
				new Station
				{
					Name = "Tulse Hill",
					Code = "TUH"
				},
				new Station
				{
					Name = "Tunbridge Wells",
					Code = "TBW"
				},
				new Station
				{
					Name = "Turkey Street",
					Code = "TUR"
				},
				new Station
				{
					Name = "Tutbury & Hatton",
					Code = "TUT"
				},
				new Station
				{
					Name = "Twickenham",
					Code = "TWI"
				},
				new Station
				{
					Name = "Twyford",
					Code = "TWY"
				},
				new Station
				{
					Name = "Ty Croes",
					Code = "TYC"
				},
				new Station
				{
					Name = "Ty Glas",
					Code = "TGS"
				},
				new Station
				{
					Name = "Tygwyn",
					Code = "TYG"
				},
				new Station
				{
					Name = "Tyndrum Lower",
					Code = "TYL"
				},
				new Station
				{
					Name = "Tyseley",
					Code = "TYS"
				},
				new Station
				{
					Name = "Tywyn",
					Code = "TYW"
				},
				new Station
				{
					Name = "Uckfield",
					Code = "UCK"
				},
				new Station
				{
					Name = "Uddingston",
					Code = "UDD"
				},
				new Station
				{
					Name = "Ulceby",
					Code = "ULC"
				},
				new Station
				{
					Name = "Ulleskelf",
					Code = "ULL"
				},
				new Station
				{
					Name = "Ulverston",
					Code = "ULV"
				},
				new Station
				{
					Name = "Umberleigh",
					Code = "UMB"
				},
				new Station
				{
					Name = "University (Birmingham)",
					Code = "UNI"
				},
				new Station
				{
					Name = "Uphall",
					Code = "UHA"
				},
				new Station
				{
					Name = "Upholland",
					Code = "UPL"
				},
				new Station
				{
					Name = "Upminster",
					Code = "UPM"
				},
				new Station
				{
					Name = "Upper Halliford",
					Code = "UPH"
				},
				new Station
				{
					Name = "Upper Holloway",
					Code = "UHL"
				},
				new Station
				{
					Name = "Upper Tyndrum",
					Code = "UTY"
				},
				new Station
				{
					Name = "Upper Warlingham",
					Code = "UWL"
				},
				new Station
				{
					Name = "Upton (Merseyside)",
					Code = "UPT"
				},
				new Station
				{
					Name = "Upwey",
					Code = "UPW"
				},
				new Station
				{
					Name = "Urmston",
					Code = "URM"
				},
				new Station
				{
					Name = "Uttoxeter",
					Code = "UTT"
				},
				new Station
				{
					Name = "Valley",
					Code = "VAL"
				},
				new Station
				{
					Name = "Vauxhall",
					Code = "VXH"
				},
				new Station
				{
					Name = "Virginia Water",
					Code = "VIR"
				},
				new Station
				{
					Name = "Waddon",
					Code = "WDO"
				},
				new Station
				{
					Name = "Wadhurst",
					Code = "WAD"
				},
				new Station
				{
					Name = "Wainfleet",
					Code = "WFL"
				},
				new Station
				{
					Name = "Wakefield Kirkgate",
					Code = "WKK"
				},
				new Station
				{
					Name = "Wakefield Westgate",
					Code = "WKF"
				},
				new Station
				{
					Name = "Walkden",
					Code = "WKD"
				},
				new Station
				{
					Name = "Wallasey Grove Road",
					Code = "WLG"
				},
				new Station
				{
					Name = "Wallasey Village",
					Code = "WLV"
				},
				new Station
				{
					Name = "Wallington",
					Code = "WLT"
				},
				new Station
				{
					Name = "Wallyford",
					Code = "WAF"
				},
				new Station
				{
					Name = "Walmer",
					Code = "WAM"
				},
				new Station
				{
					Name = "Walsall",
					Code = "WSL"
				},
				new Station
				{
					Name = "Walsden",
					Code = "WDN"
				},
				new Station
				{
					Name = "Waltham Cross",
					Code = "WLC"
				},
				new Station
				{
					Name = "Walthamstow Central",
					Code = "WHC"
				},
				new Station
				{
					Name = "Walthamstow Queen's Road",
					Code = "WMW"
				},
				new Station
				{
					Name = "Walton (Merseyside)",
					Code = "WAO"
				},
				new Station
				{
					Name = "Walton-on-Thames",
					Code = "WAL"
				},
				new Station
				{
					Name = "Walton-on-the-Naze",
					Code = "WON"
				},
				new Station
				{
					Name = "Wanborough",
					Code = "WAN"
				},
				new Station
				{
					Name = "Wandsworth Common",
					Code = "WSW"
				},
				new Station
				{
					Name = "Wandsworth Road",
					Code = "WWR"
				},
				new Station
				{
					Name = "Wandsworth Town",
					Code = "WNT"
				},
				new Station
				{
					Name = "Wanstead Park",
					Code = "WNP"
				},
				new Station
				{
					Name = "Wapping",
					Code = "WPE"
				},
				new Station
				{
					Name = "Warblington",
					Code = "WBL"
				},
				new Station
				{
					Name = "Ware (Herts)",
					Code = "WAR"
				},
				new Station
				{
					Name = "Wareham (Dorset)",
					Code = "WRM"
				},
				new Station
				{
					Name = "Wargrave",
					Code = "WGV"
				},
				new Station
				{
					Name = "Warminster",
					Code = "WMN"
				},
				new Station
				{
					Name = "Warnham",
					Code = "WNH"
				},
				new Station
				{
					Name = "Warrington Bank Quay",
					Code = "WBQ"
				},
				new Station
				{
					Name = "Warrington Central",
					Code = "WAC"
				},
				new Station
				{
					Name = "Warwick",
					Code = "WRW"
				},
				new Station
				{
					Name = "Warwick Parkway",
					Code = "WRP"
				},
				new Station
				{
					Name = "Water Orton",
					Code = "WTO"
				},
				new Station
				{
					Name = "Waterbeach",
					Code = "WBC"
				},
				new Station
				{
					Name = "Wateringbury",
					Code = "WTR"
				},
				new Station
				{
					Name = "Waterloo (Merseyside)",
					Code = "WLO"
				},
				new Station
				{
					Name = "Watford High Street",
					Code = "WFH"
				},
				new Station
				{
					Name = "Watford Junction",
					Code = "WFJ"
				},
				new Station
				{
					Name = "Watford North",
					Code = "WFN"
				},
				new Station
				{
					Name = "Watlington",
					Code = "WTG"
				},
				new Station
				{
					Name = "Watton-at-Stone",
					Code = "WAS"
				},
				new Station
				{
					Name = "Waun-Gron Park",
					Code = "WNG"
				},
				new Station
				{
					Name = "Wavertree Technology Park",
					Code = "WAV"
				},
				new Station
				{
					Name = "Wedgwood",
					Code = "WED"
				},
				new Station
				{
					Name = "Weeley",
					Code = "WEE"
				},
				new Station
				{
					Name = "Weeton",
					Code = "WET"
				},
				new Station
				{
					Name = "Welham Green",
					Code = "WMG"
				},
				new Station
				{
					Name = "Welling",
					Code = "WLI"
				},
				new Station
				{
					Name = "Wellingborough",
					Code = "WEL"
				},
				new Station
				{
					Name = "Wellington (Shropshire)",
					Code = "WLN"
				},
				new Station
				{
					Name = "Welshpool",
					Code = "WLP"
				},
				new Station
				{
					Name = "Welwyn Garden City",
					Code = "WGC"
				},
				new Station
				{
					Name = "Welwyn North",
					Code = "WLW"
				},
				new Station
				{
					Name = "Wem",
					Code = "WEM"
				},
				new Station
				{
					Name = "Wembley Central",
					Code = "WMB"
				},
				new Station
				{
					Name = "Wembley Stadium",
					Code = "WCX"
				},
				new Station
				{
					Name = "Wemyss Bay",
					Code = "WMS"
				},
				new Station
				{
					Name = "Wendover",
					Code = "WND"
				},
				new Station
				{
					Name = "Wennington",
					Code = "WNN"
				},
				new Station
				{
					Name = "West Allerton",
					Code = "WSA"
				},
				new Station
				{
					Name = "West Brompton",
					Code = "WBP"
				},
				new Station
				{
					Name = "West Byfleet",
					Code = "WBY"
				},
				new Station
				{
					Name = "West Calder",
					Code = "WCL"
				},
				new Station
				{
					Name = "West Croydon",
					Code = "WCY"
				},
				new Station
				{
					Name = "West Drayton",
					Code = "WDT"
				},
				new Station
				{
					Name = "West Dulwich",
					Code = "WDU"
				},
				new Station
				{
					Name = "West Ealing",
					Code = "WEA"
				},
				new Station
				{
					Name = "West Ham",
					Code = "WEH"
				},
				new Station
				{
					Name = "West Hampstead",
					Code = "WHD"
				},
				new Station
				{
					Name = "West Hampstead Thameslink",
					Code = "WHP"
				},
				new Station
				{
					Name = "West Horndon",
					Code = "WHR"
				},
				new Station
				{
					Name = "West Kilbride",
					Code = "WKB"
				},
				new Station
				{
					Name = "West Kirby",
					Code = "WKI"
				},
				new Station
				{
					Name = "West Malling",
					Code = "WMA"
				},
				new Station
				{
					Name = "West Norwood",
					Code = "WNW"
				},
				new Station
				{
					Name = "West Ruislip",
					Code = "WRU"
				},
				new Station
				{
					Name = "West Runton",
					Code = "WRN"
				},
				new Station
				{
					Name = "West St Leonards",
					Code = "WLD"
				},
				new Station
				{
					Name = "West Sutton",
					Code = "WSU"
				},
				new Station
				{
					Name = "West Wickham",
					Code = "WWI"
				},
				new Station
				{
					Name = "West Worthing",
					Code = "WWO"
				},
				new Station
				{
					Name = "Westbury (Wilts)",
					Code = "WSB"
				},
				new Station
				{
					Name = "Westcliff",
					Code = "WCF"
				},
				new Station
				{
					Name = "Westcombe Park",
					Code = "WCB"
				},
				new Station
				{
					Name = "Westenhanger",
					Code = "WHA"
				},
				new Station
				{
					Name = "Wester Hailes",
					Code = "WTA"
				},
				new Station
				{
					Name = "Westerfield",
					Code = "WFI"
				},
				new Station
				{
					Name = "Westerton",
					Code = "WES"
				},
				new Station
				{
					Name = "Westgate-on-Sea",
					Code = "WGA"
				},
				new Station
				{
					Name = "Westhoughton",
					Code = "WHG"
				},
				new Station
				{
					Name = "Weston Milton",
					Code = "WNM"
				},
				new Station
				{
					Name = "Weston-super-Mare",
					Code = "WSM"
				},
				new Station
				{
					Name = "Wetheral",
					Code = "WRL"
				},
				new Station
				{
					Name = "Weybridge",
					Code = "WYB"
				},
				new Station
				{
					Name = "Weymouth",
					Code = "WEY"
				},
				new Station
				{
					Name = "Whaley Bridge",
					Code = "WBR"
				},
				new Station
				{
					Name = "Whalley (Lancs)",
					Code = "WHE"
				},
				new Station
				{
					Name = "Whatstandwell",
					Code = "WTS"
				},
				new Station
				{
					Name = "Whifflet",
					Code = "WFF"
				},
				new Station
				{
					Name = "Whimple",
					Code = "WHM"
				},
				new Station
				{
					Name = "Whinhill",
					Code = "WNL"
				},
				new Station
				{
					Name = "Whiston",
					Code = "WHN"
				},
				new Station
				{
					Name = "Whitby",
					Code = "WTB"
				},
				new Station
				{
					Name = "Whitchurch (Cardiff)",
					Code = "WHT"
				},
				new Station
				{
					Name = "Whitchurch (Hants)",
					Code = "WCH"
				},
				new Station
				{
					Name = "Whitchurch (Shropshire)",
					Code = "WTC"
				},
				new Station
				{
					Name = "White Hart Lane",
					Code = "WHL"
				},
				new Station
				{
					Name = "White Notley",
					Code = "WNY"
				},
				new Station
				{
					Name = "Whitechapel",
					Code = "ZWL"
				},
				new Station
				{
					Name = "Whitecraigs",
					Code = "WCR"
				},
				new Station
				{
					Name = "Whitehaven",
					Code = "WTH"
				},
				new Station
				{
					Name = "Whitland",
					Code = "WTL"
				},
				new Station
				{
					Name = "Whitley Bridge",
					Code = "WBD"
				},
				new Station
				{
					Name = "Whitlocks End",
					Code = "WTE"
				},
				new Station
				{
					Name = "Whitstable",
					Code = "WHI"
				},
				new Station
				{
					Name = "Whittlesea",
					Code = "WLE"
				},
				new Station
				{
					Name = "Whittlesford Parkway",
					Code = "WLF"
				},
				new Station
				{
					Name = "Whitton (London)",
					Code = "WTN"
				},
				new Station
				{
					Name = "Whitwell (Derbyshire)",
					Code = "WWL"
				},
				new Station
				{
					Name = "Whyteleafe",
					Code = "WHY"
				},
				new Station
				{
					Name = "Whyteleafe South",
					Code = "WHS"
				},
				new Station
				{
					Name = "Wick",
					Code = "WCK"
				},
				new Station
				{
					Name = "Wickford",
					Code = "WIC"
				},
				new Station
				{
					Name = "Wickham Market",
					Code = "WCM"
				},
				new Station
				{
					Name = "Widdrington",
					Code = "WDD"
				},
				new Station
				{
					Name = "Widnes",
					Code = "WID"
				},
				new Station
				{
					Name = "Widney Manor",
					Code = "WMR"
				},
				new Station
				{
					Name = "Wigan North Western",
					Code = "WGN"
				},
				new Station
				{
					Name = "Wigan Wallgate",
					Code = "WGW"
				},
				new Station
				{
					Name = "Wigton",
					Code = "WGT"
				},
				new Station
				{
					Name = "Wildmill",
					Code = "WMI"
				},
				new Station
				{
					Name = "Willesden Junction",
					Code = "WIJ"
				},
				new Station
				{
					Name = "Williamwood",
					Code = "WLM"
				},
				new Station
				{
					Name = "Willington",
					Code = "WIL"
				},
				new Station
				{
					Name = "Wilmcote",
					Code = "WMC"
				},
				new Station
				{
					Name = "Wilmslow",
					Code = "WML"
				},
				new Station
				{
					Name = "Wilnecote (Staffs)",
					Code = "WNE"
				},
				new Station
				{
					Name = "Wimbledon",
					Code = "WIM"
				},
				new Station
				{
					Name = "Wimbledon Chase",
					Code = "WBO"
				},
				new Station
				{
					Name = "Winchelsea",
					Code = "WSE"
				},
				new Station
				{
					Name = "Winchester",
					Code = "WIN"
				},
				new Station
				{
					Name = "Winchfield",
					Code = "WNF"
				},
				new Station
				{
					Name = "Winchmore Hill",
					Code = "WIH"
				},
				new Station
				{
					Name = "Windermere",
					Code = "WDM"
				},
				new Station
				{
					Name = "Windsor & Eton Central",
					Code = "WNC"
				},
				new Station
				{
					Name = "Windsor & Eton Riverside",
					Code = "WNR"
				},
				new Station
				{
					Name = "Winnersh",
					Code = "WNS"
				},
				new Station
				{
					Name = "Winnersh Triangle",
					Code = "WTI"
				},
				new Station
				{
					Name = "Winsford",
					Code = "WSF"
				},
				new Station
				{
					Name = "Wishaw",
					Code = "WSH"
				},
				new Station
				{
					Name = "Witham",
					Code = "WTM"
				},
				new Station
				{
					Name = "Witley",
					Code = "WTY"
				},
				new Station
				{
					Name = "Witton (West Midlands)",
					Code = "WTT"
				},
				new Station
				{
					Name = "Wivelsfield",
					Code = "WVF"
				},
				new Station
				{
					Name = "Wivenhoe",
					Code = "WIV"
				},
				new Station
				{
					Name = "Woburn Sands",
					Code = "WOB"
				},
				new Station
				{
					Name = "Woking",
					Code = "WOK"
				},
				new Station
				{
					Name = "Wokingham",
					Code = "WKM"
				},
				new Station
				{
					Name = "Woldingham",
					Code = "WOH"
				},
				new Station
				{
					Name = "Wolverhampton",
					Code = "WVH"
				},
				new Station
				{
					Name = "Wolverton",
					Code = "WOL"
				},
				new Station
				{
					Name = "Wombwell",
					Code = "WOM"
				},
				new Station
				{
					Name = "Wood End",
					Code = "WDE"
				},
				new Station
				{
					Name = "Wood Street",
					Code = "WST"
				},
				new Station
				{
					Name = "Woodbridge",
					Code = "WDB"
				},
				new Station
				{
					Name = "Woodgrange Park",
					Code = "WGR"
				},
				new Station
				{
					Name = "Woodhall",
					Code = "WDL"
				},
				new Station
				{
					Name = "Woodhouse",
					Code = "WDH"
				},
				new Station
				{
					Name = "Woodlesford",
					Code = "WDS"
				},
				new Station
				{
					Name = "Woodley",
					Code = "WLY"
				},
				new Station
				{
					Name = "Woodmansterne",
					Code = "WME"
				},
				new Station
				{
					Name = "Woodsmoor",
					Code = "WSR"
				},
				new Station
				{
					Name = "Wool",
					Code = "WOO"
				},
				new Station
				{
					Name = "Woolston",
					Code = "WLS"
				},
				new Station
				{
					Name = "Woolwich Arsenal",
					Code = "WWA"
				},
				new Station
				{
					Name = "Woolwich Dockyard",
					Code = "WWD"
				},
				new Station
				{
					Name = "Wootton Wawen",
					Code = "WWW"
				},
				new Station
				{
					Name = "Worcester Foregate Street",
					Code = "WOF"
				},
				new Station
				{
					Name = "Worcester Park",
					Code = "WCP"
				},
				new Station
				{
					Name = "Worcester Shrub Hill",
					Code = "WOS"
				},
				new Station
				{
					Name = "Workington",
					Code = "WKG"
				},
				new Station
				{
					Name = "Worksop",
					Code = "WRK"
				},
				new Station
				{
					Name = "Worle",
					Code = "WOR"
				},
				new Station
				{
					Name = "Worplesdon",
					Code = "WPL"
				},
				new Station
				{
					Name = "Worstead",
					Code = "WRT"
				},
				new Station
				{
					Name = "Worthing",
					Code = "WRH"
				},
				new Station
				{
					Name = "Wrabness",
					Code = "WRB"
				},
				new Station
				{
					Name = "Wraysbury",
					Code = "WRY"
				},
				new Station
				{
					Name = "Wrenbury",
					Code = "WRE"
				},
				new Station
				{
					Name = "Wressle",
					Code = "WRS"
				},
				new Station
				{
					Name = "Wrexham Central",
					Code = "WXC"
				},
				new Station
				{
					Name = "Wrexham General",
					Code = "WRX"
				},
				new Station
				{
					Name = "Wye",
					Code = "WYE"
				},
				new Station
				{
					Name = "Wylam",
					Code = "WYM"
				},
				new Station
				{
					Name = "Wylde Green",
					Code = "WYL"
				},
				new Station
				{
					Name = "Wymondham",
					Code = "WMD"
				},
				new Station
				{
					Name = "Wythall",
					Code = "WYT"
				},
				new Station
				{
					Name = "Yalding",
					Code = "YAL"
				},
				new Station
				{
					Name = "Yardley Wood",
					Code = "YRD"
				},
				new Station
				{
					Name = "Yarm",
					Code = "YRM"
				},
				new Station
				{
					Name = "Yate",
					Code = "YAE"
				},
				new Station
				{
					Name = "Yatton",
					Code = "YAT"
				},
				new Station
				{
					Name = "Yeoford",
					Code = "YEO"
				},
				new Station
				{
					Name = "Yeovil Junction",
					Code = "YVJ"
				},
				new Station
				{
					Name = "Yeovil Pen Mill",
					Code = "YVP"
				},
				new Station
				{
					Name = "Yetminster",
					Code = "YET"
				},
				new Station
				{
					Name = "Ynyswen",
					Code = "YNW"
				},
				new Station
				{
					Name = "Yoker",
					Code = "YOK"
				},
				new Station
				{
					Name = "York",
					Code = "YRK"
				},
				new Station
				{
					Name = "Yorton",
					Code = "YRT"
				},
				new Station
				{
					Name = "Ystrad Mynach",
					Code = "YSM"
				},
				new Station
				{
					Name = "Ystrad Rhondda",
					Code = "YSR"
				}
			};
		}
	}
}