﻿/*
Licensed to the Apache Software Foundation (ASF) under one
or more contributor license agreements.  See the NOTICE file
distributed with this work for additional information
regarding copyright ownership.  The ASF licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License.  You may obtain a copy of the License at

  http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied.  See the License for the
specific language governing permissions and limitations
under the License.
*/

/* Fixed Data in ROM - Field and Curve parameters */

public class ROM
{
/* Don't Modify from here... */
	public const int NOT_SPECIAL = 0;
	public const int PSEUDO_MERSENNE = 1;
	public const int MONTGOMERY_FRIENDLY = 2;
	public const int WEIERSTRASS = 0;
	public const int EDWARDS = 1;
	public const int MONTGOMERY = 2;
/* ...to here */

/// <summary>
///* Enter Some Field details here  ** </summary>
// BN Curve
	public const int MODBITS = 254; // Number of bits in Modulus
	public const int MOD8 = 3; // Modulus mod 8
// Curve 25519
//	public static final int MODBITS=255;
//	public static final int MOD8=5;
// NIST256 or Brainpool
//	public static final int MODBITS=256;
//	public static final int MOD8=7;
// MF254
//	public static final int MODBITS=254;
//	public static final int MOD8=7;
// MS255
//public static final int MODBITS= 255;
//public static final int MOD8= 3;
// MF256
//	public static final int MODBITS=256;
//	public static final int MOD8=7;
// MS256
//public static final int MODBITS= 256;
//public static final int MOD8= 3;
// ANSSI
//  public static final int MODBITS= 256;
//  public static final int MOD8= 3;

/* Don't Modify from here... */
	public const int NLEN = 5;
	public const int CHUNK = 64;
	public static readonly int DNLEN = 2 * NLEN;
	public const int BASEBITS = 56;
	public static readonly long MASK = (((long)1 << BASEBITS) - 1);
	public static readonly int HBITS = BASEBITS / 2;
	public static readonly long HMASK = (((long)1 << HBITS) - 1);
	public const int MODBYTES = 32;
	public static readonly int NEXCESS = ((int)1 << (CHUNK - BASEBITS - 1));
	public static readonly long FEXCESS = ((long)1 << (BASEBITS * NLEN - MODBITS));
	public static readonly long OMASK = (long)(-1) << (MODBITS % BASEBITS);
	public static readonly int TBITS = MODBITS % BASEBITS; // Number of active bits in top word
	public static readonly long TMASK = ((long)1 << TBITS) - 1;
/* ...to here */

/* Finite field support - for RSA, DH etc. */
	public const int FF_BITS = 2048; // Finite Field Size in bits - must be 256.2^n
	public static readonly int FFLEN = (FF_BITS / 256);
	public static readonly int HFLEN = (FFLEN / 2); // Useful for half-size RSA private key operations


// START SPECIFY FIELD DETAILS HERE
//*********************************************************************************
// Curve25519 Modulus
//	public static final int MODTYPE=PSEUDO_MERSENNE;
//	public static final long[] Modulus= {0xFFFFFFFFFFFFEDL,0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0x7FFFFFFFL};
//	public static final long MConst=0x13L;


// NIST-256 Curve
//	public static final int MODTYPE=NOT_SPECIAL;
//	public static final long[] Modulus= {0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFL,0x0L,0x1000000L,0xFFFFFFFFL};
//	public static final long MConst=0x1L;

// MF254 Modulus
//	public static final int MODTYPE=MONTGOMERY_FRIENDLY;
//	public static final long[] Modulus= {0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0x3F80FFFFL};
//	public static final long MConst=0x3F810000L;

// MS255 Modulus
//public static final int MODTYPE= 1;
//public static final long[] Modulus= {0xFFFFFFFFFFFD03L,0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0x7FFFFFFFL};
//public static final long MConst=0x2FDL;

// MS256 Modulus
//public static final int MODTYPE= 1;
//public static final long[] Modulus= {0xFFFFFFFFFFFF43L,0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0xFFFFFFFFL};
//public static final long MConst=0xBDL;

// MF256 Modulus
//public static final int MODTYPE= 2;
//public static final long[] Modulus= {0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0xFFA7FFFFL};
//public static final long MConst=0xFFA80000L;

// Brainpool
//	public static final int MODTYPE= NOT_SPECIAL;
//	public static final long[] Modulus= {0x13481D1F6E5377L,0xF623D526202820L,0x909D838D726E3BL,0xA1EEA9BC3E660AL,0xA9FB57DBL};
//	public static final long MConst=0xA75590CEFD89B9L;

// ANSSI
//  public static final int MODTYPE= 0;
//  public static final long[] Modulus= {0xFCF353D86E9C03L,0xADBCABC8CA6DE8L,0xE8CE42435B3961L,0xB3AD58F10126DL,0xF1FD178CL};
//  public static final long MConst=0x97483A164E1155L;

// BNCX Curve Modulus
public const int MODTYPE = NOT_SPECIAL;
public static readonly long[] Modulus = new long[] {0x6623EF5C1B55B3L,0xD6EE18093EE1BEL,0x647A6366D3243FL,0x8702A0DB0BDDFL,0x24000000L};
public const long MConst = 0x4E205BF9789E85L;

// BN Curve
//public static final int MODTYPE=NOT_SPECIAL;
//public static final long[] Modulus= {0x13L,0x13A7L,0x80000000086121L,0x40000001BA344DL,0x25236482L};
//public static final long MConst=0x435E50D79435E5L;

// BNT Curve
//public static final int MODTYPE=NOT_SPECIAL;
//public static final long[] Modulus= {0x9DBBFEEEB4A713L,0x555614F464BABEL,0x3696F8D5F06E8AL,0x6517014EFA0BABL,0x240120DBL};
//public static final long MConst=0xC5A872D914C4E5L;

// BNT2 Curve
//public static final int MODTYPE=NOT_SPECIAL;
//public static final long[] Modulus= {0xB2DC2BB460A48BL,0x93E428F0D651E8L,0xF3B89D00081CFL,0x410F5AADB74E20L,0x24000482L};
//public static final long MConst=0xFE6A47A6505CDDL;

// START SPECIFY CURVE DETAILS HERE
//*********************************************************************************

// Ed25519 Curve
//	public static final int CURVETYPE=EDWARDS;
//	public static final int CURVE_A = -1;
//	public static final long[] CURVE_B = {0xEB4DCA135978A3L,0xA4D4141D8AB75L,0x797779E8980070L,0x2B6FFE738CC740L,0x52036CEEL};
//	public static final long[] CURVE_Order={0x12631A5CF5D3EDL,0xF9DEA2F79CD658L,0x14DEL,0x0L,0x10000000L};
//	public static final long[] CURVE_Gx ={0x562D608F25D51AL,0xC7609525A7B2C9L,0x31FDD6DC5C692CL,0xCD6E53FEC0A4E2L,0x216936D3L};
//	public static final long[] CURVE_Gy ={0x66666666666658L,0x66666666666666L,0x66666666666666L,0x66666666666666L,0x66666666L};

// Original Curve25519
//	public static final int CURVETYPE=MONTGOMERY;
//	public static final int CURVE_A =486662;
//	public static final long[] CURVE_B = {0x0L,0x0L,0x0L,0x0L,0x0L}; // not used
//	public static final long[] CURVE_Order={0x12631A5CF5D3EDL,0xF9DEA2F79CD658L,0x14DEL,0x0L,0x10000000L};
//	public static final long[] CURVE_Gx ={0x9L,0x0L,0x0L,0x0L,0x0L};
//	public static final long[] CURVE_Gy ={0x0L,0x0L,0x0L,0x0L,0x0L}; // not used

// NIST-256 Curve
//	public static final int CURVETYPE=WEIERSTRASS;
//	public static final int CURVE_A = -3;
//	public static final long[] CURVE_B = {0xCE3C3E27D2604BL,0x6B0CC53B0F63BL,0x55769886BC651DL,0xAA3A93E7B3EBBDL,0x5AC635D8L};
//	public static final long[] CURVE_Order={0xB9CAC2FC632551L,0xFAADA7179E84F3L,0xFFFFFFFFFFBCE6L,0xFFFFFFL,0xFFFFFFFFL};
//	public static final long[] CURVE_Gx ={0xA13945D898C296L,0x7D812DEB33A0F4L,0xE563A440F27703L,0xE12C4247F8BCE6L,0x6B17D1F2L};
//	public static final long[] CURVE_Gy ={0xB6406837BF51F5L,0x33576B315ECECBL,0x4A7C0F9E162BCEL,0xFE1A7F9B8EE7EBL,0x4FE342E2L};

// MF254 Modulus, Weierstrass Curve w-254-mont
//public static final int CURVETYPE= 0;
//public static final int CURVE_A = -3;
//public static final long[] CURVE_B = {0xFFFFFFFFFFD08DL,0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0x3F80FFFFL};
//public static final long[] CURVE_Order={0xA419C4AF8DF83FL,0x8BEA0DA375C06FL,0xFFFFFFFFFFEB81L,0xFFFFFFFFFFFFFFL,0x3F80FFFFL};
//public static final long[] CURVE_Gx ={0x2L,0x0L,0x0L,0x0L,0x0L};
//public static final long[] CURVE_Gy ={0x65DF37F90D4EBCL,0x38E3F8511931ADL,0x75BD778AEBDFB7L,0x3B2E56014AE15AL,0x140E3FD3L};

// MF254 Modulus, Edwards Curve ed-254-mont
//public static final int CURVETYPE= 1;
//public static final int CURVE_A = -1;
//public static final long[] CURVE_B = {0x367BL,0x0L,0x0L,0x0L,0x0L};
//public static final long[] CURVE_Order={0xF3D3FEC46E98C7L,0x306C8BD62FB0EAL,0xFFFFFFFFFFEB95L,0xFFFFFFFFFFFFFFL,0xFE03FFFL};
//public static final long[] CURVE_Gx ={0x1L,0x0L,0x0L,0x0L,0x0L};
//public static final long[] CURVE_Gy ={0x52D0FDAF2701E5L,0x9A840E3212187CL,0xD502363F4E3632L,0xD6A4C335951D00L,0x19F0E690L};

// MF254 Modulus, Montgomery Curve
//	public static final int CURVETYPE=MONTGOMERY;
//	public static final int CURVE_A =-55790;
//	public static final long[] CURVE_B = {0x0L,0x0L,0x0L,0x0L,0x0L}; // not used
//	public static final long[] CURVE_Order={0xF3D3FEC46E98C7L,0x306C8BD62FB0EAL,0xFFFFFFFFFFEB95L,0xFFFFFFFFFFFFFFL,0xFE03FFFL};
//	public static final long[] CURVE_Gx ={0x3L,0x0L,0x0L,0x0L,0x0L};
//	public static final long[] CURVE_Gy ={0x0L,0x0L,0x0L,0x0L,0x0L}; // not used

// MS255 Modulus, Weierstrass Curve
//public static final int CURVETYPE= 0;
//public static final int CURVE_A = -3;
//public static final long[] CURVE_B = {0xFFFFFFFFFFAB46L,0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0xFFFFFFFFFFFFFFL,0x7FFFFFFFL};
//public static final long[] CURVE_Order={0x8FAC983C594AEBL,0x38283AD2B3DFABL,0xFFFFFFFFFF864AL,0xFFFFFFFFFFFFFFL,0x7FFFFFFFL};
//public static final long[] CURVE_Gx ={0x1L,0x0L,0x0L,0x0L,0x0L};
//public static final long[] CURVE_Gy ={0x33FF6769CB44BAL,0xC78CDDFDA60D17L,0xF9B2FF7D177DB6L,0xEDBA7833921EBFL,0x6F7A6AC0L};

// MS255 Modulus, Edwards Curve
//public static final int CURVETYPE= 1;
//public static final int CURVE_A = -1;
//public static final long[] CURVE_B = {0xEA97L,0x0L,0x0L,0x0L,0x0L};
//public static final long[] CURVE_Order={0x49D1ED0436EB75L,0xA785EDA6832EACL,0xFFFFFFFFFFDCF1L,0xFFFFFFFFFFFFFFL,0x1FFFFFFFL};
//public static final long[] CURVE_Gx ={0x4L,0x0L,0x0L,0x0L,0x0L};
//public static final long[] CURVE_Gy ={0x2A255BD08736A0L,0x4B8AED445A45BAL,0xDD8E0C47E55291L,0x4A7BB545EC254CL,0x26CB7853L};

// MS255 Modulus, Montgomery Curve
//	public static final int CURVETYPE=MONTGOMERY;
//	public static final int CURVE_A =-240222;
//	public static final long[] CURVE_B = {0x0L,0x0L,0x0L,0x0L,0x0L}; // not used
//	public static final long[] CURVE_Order={0x49D1ED0436EB75L,0xA785EDA6832EACL,0xFFFFFFFFFFDCF1L,0xFFFFFFFFFFFFFFL,0x1FFFFFFFL};
//	public static final long[] CURVE_Gx ={0x4L,0x0L,0x0L,0x0L,0x0L};
//	public static final long[] CURVE_Gy ={0x0L,0x0L,0x0L,0x0L,0x0L}; // not used

// MS256, Weierstrass Curve
//public static final int CURVETYPE= 0;
//public static final int CURVE_A = -3;
//public static final long[] CURVE_B = {0x25581L,0x0L,0x0L,0x0L,0x0L};
//public static final long[] CURVE_Order={0xAB20294751A825L,0x8275EA265C6020L,0xFFFFFFFFFFE43CL,0xFFFFFFFFFFFFFFL,0xFFFFFFFFL};
//public static final long[] CURVE_Gx ={0x1L,0x0L,0x0L,0x0L,0x0L};
//public static final long[] CURVE_Gy ={0xF46306C2B56C77L,0x2F9375894EC10BL,0x6CCEEEDD6BD02CL,0xC1E466D7FC82C9L,0x696F1853L};

// MS256, Edwards Curve
//public static final int CURVETYPE= 1;
//public static final int CURVE_A = -1;
//public static final long[] CURVE_B = {0x3BEEL,0x0L,0x0L,0x0L,0x0L};
//public static final long[] CURVE_Order={0xB84E6F1122B4ADL,0xA55AD0A6BC64E5L,0xFFFFFFFFFFBE6AL,0xFFFFFFFFFFFFFFL,0x3FFFFFFFL};
//public static final long[] CURVE_Gx ={0xDL,0x0L,0x0L,0x0L,0x0L};
//public static final long[] CURVE_Gy ={0x7F6FB5331CADBAL,0x6D63824D303F70L,0xB39FA046BFBE2AL,0x2A1276DBA3D330L,0x7D0AB41EL};

// MS256 Modulus, Montgomery Curve
//	public static final int CURVETYPE=MONTGOMERY;
//	public static final int CURVE_A =-61370;
//	public static final long[] CURVE_B = {0x0L,0x0L,0x0L,0x0L,0x0L}; // not used
//  public static final long[] CURVE_Order={0xB84E6F1122B4ADL,0xA55AD0A6BC64E5L,0xFFFFFFFFFFBE6AL,0xFFFFFFFFFFFFFFL,0x3FFFFFFFL};
//	public static final long[] CURVE_Gx ={0xbL,0x0L,0x0L,0x0L,0x0L};
//	public static final long[] CURVE_Gy ={0x0L,0x0L,0x0L,0x0L,0x0L}; // not used

// MF256 Modulus, Weierstrass Curve
//public static final int CURVETYPE= 0;
//public static final int CURVE_A = -3;
//public static final long[] CURVE_B = {0x14E6AL,0x0L,0x0L,0x0L,0x0L};
//public static final long[] CURVE_Order={0x10C5E1A79857EBL,0x7513E6E5074B9DL,0xFFFFFFFFFFFC51L,0xFFFFFFFFFFFFFFL,0xFFA7FFFFL};
//public static final long[] CURVE_Gx ={0x1L,0x0L,0x0L,0x0L,0x0L};
//public static final long[] CURVE_Gy ={0x7954C2B724D2AL,0x47EB8D94DC6610L,0x26123DAE289569L,0xBE1808CE7BABBAL,0x20887C87L};

// MF256, Edwards Curve
//public static final int CURVETYPE= 1;
//public static final int CURVE_A = -1;
//public static final long[] CURVE_B = {0x350AL,0x0L,0x0L,0x0L,0x0L};
//public static final long[] CURVE_Order={0xD92EDED8EC7BABL,0xBBAFB86733C966L,0xFFFFFFFFFFB154L,0xFFFFFFFFFFFFFFL,0x3FE9FFFFL};
//public static final long[] CURVE_Gx ={0x1L,0x0L,0x0L,0x0L,0x0L};
//public static final long[] CURVE_Gy ={0xEAA722F2F3C908L,0x5E648DFEA68D7DL,0xF3DB2C1AACA0C0L,0xF8CC4D5AEAEBEEL,0xDAD8D4F8L};

// MF256 Modulus, Montgomery Curve
//	public static final int CURVETYPE=MONTGOMERY;
//	public static final int CURVE_A =-54314;
//	public static final long[] CURVE_B = {0x0L,0x0L,0x0L,0x0L,0x0L}; // not used
//  public static final long[] CURVE_Order={0xD92EDED8EC7BABL,0xBBAFB86733C966L,0xFFFFFFFFFFB154L,0xFFFFFFFFFFFFFFL,0x3FE9FFFFL};
//	public static final long[] CURVE_Gx ={0x8L,0x0L,0x0L,0x0L,0x0L};
//	public static final long[] CURVE_Gy ={0x0L,0x0L,0x0L,0x0L,0x0L}; // not used



// Brainpool
//	public static final int CURVETYPE= 0;
//	public static final int CURVE_A = -3;
//	public static final long[] CURVE_B = {0xE58101FEE92B04L,0xEBC4AF2F49256AL,0x733D0B76B7BF93L,0x30D84EA4FE66A7L,0x662C61C4L};
//	public static final long[] CURVE_Order={0x1E0E82974856A7L,0x7AA3B561A6F790L,0x909D838D718C39L,0xA1EEA9BC3E660AL,0xA9FB57DBL};
//	public static final long[] CURVE_Gx ={0xA191562E1305F4L,0x42C47AAFBC2B79L,0xB23A656149AFA1L,0xC1CFE7B7732213L,0xA3E8EB3CL};
//	public static final long[] CURVE_Gy ={0xABE8F35B25C9BEL,0xB6DE39D027001DL,0xE14644417E69BCL,0x3439C56D7F7B22L,0x2D996C82L};

// ANSSI
//  public static final int CURVETYPE= 0;
//  public static final int CURVE_A = -3;
//  public static final long[] CURVE_B = {0x75ED967B7BB73FL,0xC9AE4B1A18030L,0x754A44C00FDFECL,0x5428A9300D4ABAL,0xEE353FCAL};
//  public static final long[] CURVE_Order={0xFDD459C6D655E1L,0x67E140D2BF941FL,0xE8CE42435B53DCL,0xB3AD58F10126DL,0xF1FD178CL};
//  public static final long[] CURVE_Gx ={0xC97A2DD98F5CFFL,0xD2DCAF98B70164L,0x4749D423958C27L,0x56C139EB31183DL,0xB6B3D4C3L};
//  public static final long[] CURVE_Gy ={0x115A1554062CFBL,0xC307E8E4C9E183L,0xF0F3ECEF8C2701L,0xC8B204911F9271L,0x6142E0F7L};

// BNCX Curve

	public const int CURVETYPE = WEIERSTRASS;
	public const int CURVE_A = 0;
	public static readonly long[] CURVE_B = new long[] {0x2L,0x0L,0x0L,0x0L,0x0L};
	public static readonly long[] CURVE_Order = new long[] {0x11C0A636EB1F6DL,0xD6EE0CC906CEBEL,0x647A6366D2C43FL,0x8702A0DB0BDDFL,0x24000000L};
	public static readonly long[] CURVE_Bnx = new long[] {0x3C012B1L,0x40L,0x0L,0x0L,0x0L};
	public static readonly long[] CURVE_Cru = new long[] {0xE0931794235C97L,0xDF6471EF875631L,0xCA83F1440BDL,0x480000L,0x0L};
	public static readonly long[] CURVE_Fra = new long[] {0xD9083355C80EA3L,0x7326F173F8215BL,0x8AACA718986867L,0xA63A0164AFE18BL,0x1359082FL};
	public static readonly long[] CURVE_Frb = new long[] {0x8D1BBC06534710L,0x63C7269546C062L,0xD9CDBC4E3ABBD8L,0x623628A900DC53L,0x10A6F7D0L};
	public static readonly long[] CURVE_Pxa = new long[] {0x851CEEE4D2EC74L,0x85BFA03E2726C0L,0xF5C34BBB907CL,0x7053B256358B25L,0x19682D2CL};
	public static readonly long[] CURVE_Pxb = new long[] {0xA58E8B2E29CFE1L,0x97B0C209C30F47L,0x37A8E99743F81BL,0x3E19F64AA011C9L,0x1466B9ECL};
	public static readonly long[] CURVE_Pya = new long[] {0xFBFCEBCF0BE09FL,0xB33D847EC1B30CL,0x157DAEE2096361L,0x72332B8DD81E22L,0xA79EDD9L};
	public static readonly long[] CURVE_Pyb = new long[] {0x904B228898EE9DL,0x4EA569D2EDEBEDL,0x512D8D3461C286L,0xECC4C09035C6E4L,0x6160C39L};
	public static readonly long[] CURVE_Gx = new long[] {0x6623EF5C1B55B2L,0xD6EE18093EE1BEL,0x647A6366D3243FL,0x8702A0DB0BDDFL,0x24000000L};
	public static readonly long[] CURVE_Gy = new long[] {0x1L,0x0L,0x0L,0x0L,0x0L};
	public static readonly long[][] CURVE_W = new long[][]
	{
		new long[] {0x546349162FEB83L,0xB40381200L,0x6000L,0x0L,0x0L},
		new long[] {0x7802561L,0x80L,0x0L,0x0L,0x0L}
	};
	public static readonly long[][][] CURVE_SB = new long[][][]
	{
		new long[][]
		{
			new long[] {0x5463491DB010E4L,0xB40381280L,0x6000L,0x0L,0x0L},
			new long[] {0x7802561L,0x80L,0x0L,0x0L,0x0L}
		},
		new long[][]
		{
			new long[] {0x7802561L,0x80L,0x0L,0x0L,0x0L},
			new long[] {0xBD5D5D20BB33EAL,0xD6EE0188CEBCBDL,0x647A6366D2643FL,0x8702A0DB0BDDFL,0x24000000L}
		}
	};
	public static readonly long[][] CURVE_WB = new long[][]
	{
		new long[] {0x1C2118567A84B0L,0x3C012B040L,0x2000L,0x0L,0x0L},
		new long[] {0xCDF995BE220475L,0x94EDA8CA7F9A36L,0x8702A0DC07EL,0x300000L,0x0L},
		new long[] {0x66FCCAE0F10B93L,0x4A76D4653FCD3BL,0x4381506E03FL,0x180000L,0x0L},
		new long[] {0x1C21185DFAAA11L,0x3C012B0C0L,0x2000L,0x0L,0x0L}
	};
	public static readonly long[][][] CURVE_BB = new long[][][]
	{
		new long[][]
		{
			new long[] {0x11C0A6332B0CBDL,0xD6EE0CC906CE7EL,0x647A6366D2C43FL,0x8702A0DB0BDDFL,0x24000000L},
			new long[] {0x11C0A6332B0CBCL,0xD6EE0CC906CE7EL,0x647A6366D2C43FL,0x8702A0DB0BDDFL,0x24000000L},
			new long[] {0x11C0A6332B0CBCL,0xD6EE0CC906CE7EL,0x647A6366D2C43FL,0x8702A0DB0BDDFL,0x24000000L},
			new long[] {0x7802562L,0x80L,0x0L,0x0L,0x0L}
		},
		new long[][]
		{
			new long[] {0x7802561L,0x80L,0x0L,0x0L,0x0L},
			new long[] {0x11C0A6332B0CBCL,0xD6EE0CC906CE7EL,0x647A6366D2C43FL,0x8702A0DB0BDDFL,0x24000000L},
			new long[] {0x11C0A6332B0CBDL,0xD6EE0CC906CE7EL,0x647A6366D2C43FL,0x8702A0DB0BDDFL,0x24000000L},
			new long[] {0x11C0A6332B0CBCL,0xD6EE0CC906CE7EL,0x647A6366D2C43FL,0x8702A0DB0BDDFL,0x24000000L}
		},
		new long[][]
		{
			new long[] {0x7802562L,0x80L,0x0L,0x0L,0x0L},
			new long[] {0x7802561L,0x80L,0x0L,0x0L,0x0L},
			new long[] {0x7802561L,0x80L,0x0L,0x0L,0x0L},
			new long[] {0x7802561L,0x80L,0x0L,0x0L,0x0L}
		},
		new long[][]
		{
			new long[] {0x3C012B2L,0x40L,0x0L,0x0L,0x0L},
			new long[] {0xF004AC2L,0x100L,0x0L,0x0L,0x0L},
			new long[] {0x11C0A62F6AFA0AL,0xD6EE0CC906CE3EL,0x647A6366D2C43FL,0x8702A0DB0BDDFL,0x24000000L},
			new long[] {0x3C012B2L,0x40L,0x0L,0x0L,0x0L}
		}
	};

	public const bool USE_GLV = true;
	public const bool USE_GS_G2 = true;
	public const bool USE_GS_GT = true;
	public const bool GT_STRONG = true;

// BNT Curve
/*
public static final int CURVETYPE=WEIERSTRASS;
public static final int CURVE_A = 0;
public static final long[] CURVE_B = {0x2L,0x0L,0x0L,0x0L,0x0L};
public static final long[] CURVE_Order={0x75777E8D30210DL,0xD43492B2CB363AL,0x3696F8D5F00E88L,0x6517014EFA0BABL,0x240120DBL};
public static final long[] CURVE_Bnx={0x806000004081L,0x40L,0x0L,0x0L,0x0L};
public static final long[] CURVE_Cru={0xEB53D5AB4FCD87L,0x82A5F2BAB11FADL,0x47651504C9764CL,0x4801B1L,0x0L};
public static final long[] CURVE_Fra={0xF5D14EADC80022L,0x4904D6FACCE359L,0xF190A13211BE6CL,0xC9BBC4394F6509L,0x1328A292L};
public static final long[] CURVE_Frb={0xA7EAB040ECA6F1L,0xC513DF997D764L,0x450657A3DEB01EL,0x9B5B3D15AAA6A1L,0x10D87E48L};
public static final long[] CURVE_Pxa={0x8987E2288E65BBL,0xAD1CAA6313BEL,0x325041548B7CCCL,0x4C1339EBCC055L,0x14483FCDL};
public static final long[] CURVE_Pxb={0x67888808DBE2C0L,0x7FE1F81E34853AL,0xA631A51B57B95L,0x384EC302DA3FC5L,0x87F46B3L};
public static final long[] CURVE_Pya={0x202C47E020CA1DL,0xB4167E8399F36CL,0xC6E5439F72C94CL,0x102B0BD74A2C69L,0x14E8C29CL};
public static final long[] CURVE_Pyb={0xD8437C716628F2L,0x27E167BCB7DC6BL,0xA82C7572681D0AL,0x62454BD1EDEC18L,0x17AFE2A4L};
public static final long[] CURVE_Gx ={0x9DBBFEEEB4A712L,0x555614F464BABEL,0x3696F8D5F06E8AL,0x6517014EFA0BABL,0x240120DBL};
public static final long[] CURVE_Gy ={0x1L,0x0L,0x0L,0x0L,0x0L};
public static final long[][] CURVE_W={{0x26430061838403L,0x81218241998384L,0x6001L,0x0L,0x0L},{0x100C000008101L,0x80L,0x0L,0x0L,0x0L}};
public static final long[][][] CURVE_SB={{{0x2743C061840504L,0x81218241998404L,0x6001L,0x0L,0x0L},{0x100C000008101L,0x80L,0x0L,0x0L,0x0L}},{{0x100C000008101L,0x80L,0x0L,0x0L,0x0L},{0x4F347E2BAC9D0AL,0x5313107131B2B6L,0x3696F8D5EFAE87L,0x6517014EFA0BABL,0x240120DBL}}};
public static final long[][] CURVE_WB={{0x6140602080C080L,0x806080C08880C1L,0x2000L,0x0L,0x0L},{0xB53904088C4A85L,0xAD2FA352DC6C36L,0xDA436358868EDEL,0x300120L,0x0L},{0x5ADCB204464583L,0x5697D1A96E363BL,0x6D21B1AC43476FL,0x180090L,0x0L},{0x62412020814181L,0x806080C0888141L,0x2000L,0x0L,0x0L}};
public static final long[][][] CURVE_BB={{{0x74F71E8D2FE08DL,0xD43492B2CB35FAL,0x3696F8D5F00E88L,0x6517014EFA0BABL,0x240120DBL},{0x74F71E8D2FE08CL,0xD43492B2CB35FAL,0x3696F8D5F00E88L,0x6517014EFA0BABL,0x240120DBL},{0x74F71E8D2FE08CL,0xD43492B2CB35FAL,0x3696F8D5F00E88L,0x6517014EFA0BABL,0x240120DBL},{0x100C000008102L,0x80L,0x0L,0x0L,0x0L}},{{0x100C000008101L,0x80L,0x0L,0x0L,0x0L},{0x74F71E8D2FE08CL,0xD43492B2CB35FAL,0x3696F8D5F00E88L,0x6517014EFA0BABL,0x240120DBL},{0x74F71E8D2FE08DL,0xD43492B2CB35FAL,0x3696F8D5F00E88L,0x6517014EFA0BABL,0x240120DBL},{0x74F71E8D2FE08CL,0xD43492B2CB35FAL,0x3696F8D5F00E88L,0x6517014EFA0BABL,0x240120DBL}},{{0x100C000008102L,0x80L,0x0L,0x0L,0x0L},{0x100C000008101L,0x80L,0x0L,0x0L,0x0L},{0x100C000008101L,0x80L,0x0L,0x0L,0x0L},{0x100C000008101L,0x80L,0x0L,0x0L,0x0L}},{{0x806000004082L,0x40L,0x0L,0x0L,0x0L},{0x2018000010202L,0x100L,0x0L,0x0L,0x0L},{0x7476BE8D2FA00AL,0xD43492B2CB35BAL,0x3696F8D5F00E88L,0x6517014EFA0BABL,0x240120DBL},{0x806000004082L,0x40L,0x0L,0x0L,0x0L}}};

*/

// BNT2 Curve
/*
	public static final int CURVETYPE=WEIERSTRASS;
	public static final int CURVE_A = 0;
	public static final long[] CURVE_B = {0x2L,0x0L,0x0L,0x0L,0x0L};
	public static final long[] CURVE_Order={0xFB71A511AA2BF5L,0x8DE127B73833D7L,0xF3B89D00021CFL,0x410F5AADB74E20L,0x24000482L};
	public static final long[] CURVE_Bnx={0x20100608205L,0x40L,0x0L,0x0L,0x0L};
	public static final long[] CURVE_Cru={0x5027444866BD33L,0x5B773016470EFBL,0xC3617BECF23675L,0x480006L,0x0L};
	public static final long[] CURVE_Fra={0xB268C973AEF062L,0xC69B33C3BCE492L,0xF67FA37F195BBCL,0x29E8CAB6BD0A41L,0x124E0B8DL};
	public static final long[] CURVE_Frb={0x736240B1B429L,0xCD48F52D196D56L,0x18BBE650E72612L,0x17268FF6FA43DEL,0x11B1F8F5L};
	public static final long[] CURVE_Pxa={0xCC92399F40A3C8L,0xCDA4E96611784AL,0x7B056961706B35L,0x9693C6318279D7L,0x16FC17CFL};
	public static final long[] CURVE_Pxb={0x557A8AD8549540L,0x6F7BE6F6510610L,0x565907A95D17DBL,0xBD5975909C8188L,0x1EB5B500L};
	public static final long[] CURVE_Pya={0x7BECC514220513L,0x4A78860E737B14L,0x51B83935F12684L,0x761422AA9D4DFAL,0x1E8EE498L};
	public static final long[] CURVE_Pyb={0xB9328F577CE78EL,0xB746E26FA5781FL,0xA93DBC1FB8E27EL,0xBAE33BDBA29D76L,0x23CEF4CDL};
	public static final long[] CURVE_Gx ={0xB2DC2BB460A48AL,0x93E428F0D651E8L,0xF3B89D00081CFL,0x410F5AADB74E20L,0x24000482L};
	public static final long[] CURVE_Gy ={0x1L,0x0L,0x0L,0x0L,0x0L};
	public static final long[][] CURVE_W={{0xB76282A1347083L,0x60301399E1D10L,0x6000L,0x0L,0x0L},{0x40200C10409L,0x80L,0x0L,0x0L,0x0L}};
	public static final long[][][] CURVE_SB={{{0xB76684A1F5748CL,0x60301399E1D90L,0x6000L,0x0L,0x0L},{0x40200C10409L,0x80L,0x0L,0x0L,0x0L}},{{0x40200C10409L,0x80L,0x0L,0x0L,0x0L},{0x440F227075BB72L,0x87DE267D9A16C7L,0xF3B89CFFFC1CFL,0x410F5AADB74E20L,0x24000482L}}};
	public static final long[][] CURVE_WB={{0x9272D48A70A224L,0x20100688A0945L,0x2000L,0x0L,0x0L},{0x5A572CF030EF19L,0x9651763543721DL,0x8240FD48A1B9A3L,0x300004L,0x0L},{0xAD2C96F848B88FL,0xCB28BB1AA1B92EL,0x41207EA450DCD1L,0x180002L,0x0L},{0x9276D68B31A62DL,0x20100688A09C5L,0x2000L,0x0L,0x0L}};
	public static final long[][][] CURVE_BB={{{0xFB6FA41149A9F1L,0x8DE127B7383397L,0xF3B89D00021CFL,0x410F5AADB74E20L,0x24000482L},{0xFB6FA41149A9F0L,0x8DE127B7383397L,0xF3B89D00021CFL,0x410F5AADB74E20L,0x24000482L},{0xFB6FA41149A9F0L,0x8DE127B7383397L,0xF3B89D00021CFL,0x410F5AADB74E20L,0x24000482L},{0x40200C1040AL,0x80L,0x0L,0x0L,0x0L}},{{0x40200C10409L,0x80L,0x0L,0x0L,0x0L},{0xFB6FA41149A9F0L,0x8DE127B7383397L,0xF3B89D00021CFL,0x410F5AADB74E20L,0x24000482L},{0xFB6FA41149A9F1L,0x8DE127B7383397L,0xF3B89D00021CFL,0x410F5AADB74E20L,0x24000482L},{0xFB6FA41149A9F0L,0x8DE127B7383397L,0xF3B89D00021CFL,0x410F5AADB74E20L,0x24000482L}},{{0x40200C1040AL,0x80L,0x0L,0x0L,0x0L},{0x40200C10409L,0x80L,0x0L,0x0L,0x0L},{0x40200C10409L,0x80L,0x0L,0x0L,0x0L},{0x40200C10409L,0x80L,0x0L,0x0L,0x0L}},{{0x20100608206L,0x40L,0x0L,0x0L,0x0L},{0x80401820812L,0x100L,0x0L,0x0L,0x0L},{0xFB6DA310E927EAL,0x8DE127B7383357L,0xF3B89D00021CFL,0x410F5AADB74E20L,0x24000482L},{0x20100608206L,0x40L,0x0L,0x0L,0x0L}}};
*/

// BN Curve
/*
public static final int CURVETYPE=WEIERSTRASS;
public static final int CURVE_A = 0;
public static final long[] CURVE_B = {0x2L,0x0L,0x0L,0x0L,0x0L};
public static final long[] CURVE_Order={0xDL,0x800000000010A1L,0x8000000007FF9FL,0x40000001BA344DL,0x25236482L};
public static final long[] CURVE_Bnx={0x80000000000001L,0x40L,0x0L,0x0L,0x0L};
public static final long[] CURVE_Cru={0x80000000000007L,0x6CDL,0x40000000024909L,0x49B362L,0x0L};
public static final long[] CURVE_Fra={0x7DE6C06F2A6DE9L,0x74924D3F77C2E1L,0x50A846953F8509L,0x212E7C8CB6499BL,0x1B377619L};
public static final long[] CURVE_Frb={0x82193F90D5922AL,0x8B6DB2C08850C5L,0x2F57B96AC8DC17L,0x1ED1837503EAB2L,0x9EBEE69L};
public static final long[] CURVE_Pxa={0xAB2C7935FD0CB4L,0xE319E4FCC57C2BL,0x24F6DF763B05A5L,0xF55EA7EA335FB7L,0x95B04D4L};
public static final long[] CURVE_Pxb={0xA07D0790962455L,0x86BE3D27AA5E38L,0x89E05747F39D6DL,0xC08347B49D42BFL,0x5D4D8A7L};
public static final long[] CURVE_Pya={0xADCE687A08A46CL,0x2B30E98A4191F9L,0x4C3784B1F16908L,0x25E5313FA16D1CL,0xABF2ABFL};
public static final long[] CURVE_Pyb={0xDF88D405F306ECL,0x82076ADD13A0E6L,0x1E47819D6A5C04L,0xE679DABDB38627L,0x18769A87L};
public static final long[] CURVE_Gx ={0x12L,0x13A7L,0x80000000086121L,0x40000001BA344DL,0x25236482L};
public static final long[] CURVE_Gy ={0x1L,0x0L,0x0L,0x0L,0x0L};
public static final long[][] CURVE_W={{0x3L,0x80000000000204L,0x6181L,0x0L,0x0L},{0x1L,0x81L,0x0L,0x0L,0x0L}};
public static final long[][][] CURVE_SB={{{0x4L,0x80000000000285L,0x6181L,0x0L,0x0L},{0x1L,0x81L,0x0L,0x0L,0x0L}},{{0x1L,0x81L,0x0L,0x0L,0x0L},{0xAL,0xE9DL,0x80000000079E1EL,0x40000001BA344DL,0x25236482L}}};
public static final long[][] CURVE_WB={{0x80000000000000L,0x80000000000040L,0x2080L,0x0L,0x0L},{0x80000000000005L,0x54AL,0x8000000001C707L,0x312241L,0x0L},{0x80000000000003L,0x800000000002C5L,0xC000000000E383L,0x189120L,0x0L},{0x80000000000001L,0x800000000000C1L,0x2080L,0x0L,0x0L}};
public static final long[][][] CURVE_BB={{{0x8000000000000DL,0x80000000001060L,0x8000000007FF9FL,0x40000001BA344DL,0x25236482L},{0x8000000000000CL,0x80000000001060L,0x8000000007FF9FL,0x40000001BA344DL,0x25236482L},{0x8000000000000CL,0x80000000001060L,0x8000000007FF9FL,0x40000001BA344DL,0x25236482L},{0x2L,0x81L,0x0L,0x0L,0x0L}},{{0x1L,0x81L,0x0L,0x0L,0x0L},{0x8000000000000CL,0x80000000001060L,0x8000000007FF9FL,0x40000001BA344DL,0x25236482L},{0x8000000000000DL,0x80000000001060L,0x8000000007FF9FL,0x40000001BA344DL,0x25236482L},{0x8000000000000CL,0x80000000001060L,0x8000000007FF9FL,0x40000001BA344DL,0x25236482L}},{{0x2L,0x81L,0x0L,0x0L,0x0L},{0x1L,0x81L,0x0L,0x0L,0x0L},{0x1L,0x81L,0x0L,0x0L,0x0L},{0x1L,0x81L,0x0L,0x0L,0x0L}},{{0x80000000000002L,0x40L,0x0L,0x0L,0x0L},{0x2L,0x102L,0x0L,0x0L,0x0L},{0xAL,0x80000000001020L,0x8000000007FF9FL,0x40000001BA344DL,0x25236482L},{0x80000000000002L,0x40L,0x0L,0x0L,0x0L}}};

*/

//	public static boolean debug=false;

}
