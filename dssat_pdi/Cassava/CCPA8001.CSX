*EXP.DETAILS: CCPA8001CS 1980 FOUR CULTIVARS

*GENERAL
@PEOPLE
VELTKAMP,H.J.
@ADDRESS
-99
@SITE
PALMIRA,COLOMBIA  3.52;-76.35;423;AW
@NOTES
AGRICULTURAL UNIVERSITY,WAGENINGEN,NETHERLANDS CIAT Experiment 3


*TREATMENTS                        -------------FACTOR LEVELS------------
@N R O C TNAME.................... CU FL SA IC MP MI MF MR MC MT ME MH SM
 1 1 0 0 C1 MCol-1684               1  1  0  1  1  0  0  0  0  0  0  1  1
 2 1 0 0 C2 MMex-59                 2  1  0  1  1  0  0  0  0  0  0  1  1
 3 1 0 0 C3 MCo-l638                3  1  0  1  1  0  0  0  0  0  0  1  1
 4 1 0 0 C4 MPtr-26                 4  1  0  1  1  0  0  0  0  0  0  1  1

*CULTIVARS
@C CR INGENO CNAME
 1 CS UC0006 MCol-1684
 2 CS UC0004 MMex-59
 3 CS UC0009 MCol-638
 4 CS UC0008 MPtr-26

*FIELDS
@L ID_FIELD WSTA....  FLSA  FLOB  FLDT  FLDD  FLDS  FLST SLTX  SLDP  ID_SOIL    FLNAME
 1 CIAT0001 CCPA       -99   -99   -99   -99   -99   -99 -99    209  CCPA000030 -99
@L ...........XCRD ...........YCRD .....ELEV .............AREA .SLEN .FLWR .SLAS FLHST FHDUR
 1               0               0         0                 0     0     0     0   -99   -99

*INITIAL CONDITIONS
@C   PCR ICDAT  ICRT  ICND  ICRN  ICRE  ICWD ICRES ICREN ICREP ICRIP ICRID ICNAME
 1   -99 80029   -99     0     1     1   -99     0     0     0   100    15 -99
@C  ICBL  SH2O  SNH4  SNO3
 1     5   .34   -99   -99
 1    15   .34   -99   -99
 1    25  .345   -99   -99
 1    35  .345   -99   -99
 1    50  .335   -99   -99
 1    65  .323   -99   -99
 1    80  .323   -99   -99
 1    99  .328   -99   -99
 1   122  .325   -99   -99
 1   137  .288   -99   -99
 1   159  .242   -99   -99
 1   184  .177   -99   -99
 1   209  .193   -99   -99

*PLANTING DETAILS
@P PDATE EDATE  PPOP  PPOE  PLME  PLDS  PLRS  PLRD  PLDP  PLWT  PAGE  PENV  PLPH  SPRL                        PLNAME
 1 80029   -99     1     1     V   -99   100    90    20   450   -99   -99     1    25                        -99

*HARVEST DETAILS
@H HDATE  HSTG  HCOM HSIZE   HPC  HBPC HNAME
 1 80332 GS000   -99   -99   -99   -99 

*SIMULATION CONTROLS
@N GENERAL     NYERS NREPS START SDATE RSEED SNAME.................... SMODEL
 1 GE              1     1     P 80029  2150 Cultivars  4C  (Veltkam3
@N OPTIONS     WATER NITRO SYMBI PHOSP POTAS DISES  CHEM  TILL   CO2
 1 OP              Y     N     N     N     N     N     N     Y     M
@N METHODS     WTHER INCON LIGHT EVAPO INFIL PHOTO HYDRO NSWIT MESOM MESEV MESOL
 1 ME              M     M     E     R     S     R     R     1     G     R     2
@N MANAGEMENT  PLANT IRRIG FERTI RESID HARVS
 1 MA              R     A     N     N     R
@N OUTPUTS     FNAME OVVEW SUMRY FROPT GROUT CAOUT WAOUT NIOUT MIOUT DIOUT VBOSE CHOUT OPOUT FMOPT
 1 OU              N     Y     Y     1     Y     N     Y     Y     N     N     Y     N     N     A

@  AUTOMATIC MANAGEMENT
@N PLANTING    PFRST PLAST PH2OL PH2OU PH2OD PSTMX PSTMN
 1 PL          80022 80036    40   100    30    40    10
@N IRRIGATION  IMDEP ITHRL ITHRU IROFF IMETH IRAMT IREFF
 1 IR             30    50   100 IB001 IBI01    10     1
@N NITROGEN    NMDEP NMTHR NAMNT NCODE NAOFF
 1 NI             30    50    25 IB001 IB001
@N RESIDUES    RIPCN RTIME RIDEP
 1 RE            100     1    20
@N HARVEST     HFRST HLAST HPCNP HPCNR
 1 HA              0 81028   100     0



