--
-- PostgreSQL database dump
--

-- Dumped from database version 15.1
-- Dumped by pg_dump version 15rc2

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: count_randevu_doktor(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.count_randevu_doktor(kisiid integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
  RETURN (SELECT COUNT(*) FROM randevu WHERE doktorid = kisiid);
END;
$$;


ALTER FUNCTION public.count_randevu_doktor(kisiid integer) OWNER TO postgres;

--
-- Name: count_randevu_for_hasta(integer); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.count_randevu_for_hasta(IN kisiid integer)
    LANGUAGE plpgsql
    AS $$
BEGIN
  SELECT count_randevu_hasta(kisiid);
END;
$$;


ALTER PROCEDURE public.count_randevu_for_hasta(IN kisiid integer) OWNER TO postgres;

--
-- Name: count_randevu_hasta(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.count_randevu_hasta(kisiid integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
  RETURN (SELECT COUNT(*) FROM randevu WHERE hastaid = kisiid);
END;
$$;


ALTER FUNCTION public.count_randevu_hasta(kisiid integer) OWNER TO postgres;

--
-- Name: count_tedavi_doktor(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.count_tedavi_doktor(kisiid integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
  RETURN (SELECT COUNT(*) FROM tedavi WHERE doktorid = kisiid);
END;
$$;


ALTER FUNCTION public.count_tedavi_doktor(kisiid integer) OWNER TO postgres;

--
-- Name: count_tedavi_hasta(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.count_tedavi_hasta(kisiid integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
  RETURN (SELECT COUNT(*) FROM tedavi WHERE hastaid = kisiid);
END;
$$;


ALTER FUNCTION public.count_tedavi_hasta(kisiid integer) OWNER TO postgres;

--
-- Name: hastatoplamodeme(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.hastatoplamodeme(kisiid integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
  RETURN (SELECT SUM(ucret) FROM tedavi WHERE hastaid = kisiid);
END;
$$;


ALTER FUNCTION public.hastatoplamodeme(kisiid integer) OWNER TO postgres;

--
-- Name: urunFiyatDegisimKaydi(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."urunFiyatDegisimKaydi"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    IF NEW."ucret" <> OLD."ucret" THEN
    INSERT INTO "urunFiyatDegisim"("urun_ID","eskiBirimFiyat","yeniBirimFiyat","degisiklilikTarihi")
    VALUES (OLD."urun_ID",OLD."ucret",NEW."ucret",CURRENT_TIMESTAMP::TIMESTAMP);
    END IF;
    
    RETURN NEW;
END;
$$;


ALTER FUNCTION public."urunFiyatDegisimKaydi"() OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: doktor; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.doktor (
    kisiid integer NOT NULL,
    pozisyon character varying(40) NOT NULL,
    maas integer NOT NULL
);


ALTER TABLE public.doktor OWNER TO postgres;

--
-- Name: duyurular; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.duyurular (
    duyuruid integer NOT NULL,
    baslik character varying(40) NOT NULL,
    aciklama text NOT NULL
);


ALTER TABLE public.duyurular OWNER TO postgres;

--
-- Name: duyurular_duyuruid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.duyurular_duyuruid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.duyurular_duyuruid_seq OWNER TO postgres;

--
-- Name: duyurular_duyuruid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.duyurular_duyuruid_seq OWNED BY public.duyurular.duyuruid;


--
-- Name: ekipman; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ekipman (
    ekipmanid integer NOT NULL,
    isim character varying(40) NOT NULL,
    modelnumarasi character varying(40) NOT NULL,
    bakimsikligi text NOT NULL,
    uretici character varying(40) NOT NULL,
    urunid integer NOT NULL
);


ALTER TABLE public.ekipman OWNER TO postgres;

--
-- Name: ekipman_ekipman_ID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."ekipman_ekipman_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."ekipman_ekipman_ID_seq" OWNER TO postgres;

--
-- Name: ekipman_ekipman_ID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."ekipman_ekipman_ID_seq" OWNED BY public.ekipman.ekipmanid;


--
-- Name: envanter; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.envanter (
    urunid integer NOT NULL,
    adet integer NOT NULL,
    tedarikci character varying(40) NOT NULL,
    ucret real NOT NULL
);


ALTER TABLE public.envanter OWNER TO postgres;

--
-- Name: envanter_urun_ID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."envanter_urun_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."envanter_urun_ID_seq" OWNER TO postgres;

--
-- Name: envanter_urun_ID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."envanter_urun_ID_seq" OWNED BY public.envanter.urunid;


--
-- Name: gorusoneri; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.gorusoneri (
    gorusoneriid integer NOT NULL,
    isim character varying(40) NOT NULL,
    soyisim character varying(40) NOT NULL,
    baslik character varying(40) NOT NULL,
    aciklama text NOT NULL
);


ALTER TABLE public.gorusoneri OWNER TO postgres;

--
-- Name: gorusoneri_gorusoneriid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.gorusoneri_gorusoneriid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.gorusoneri_gorusoneriid_seq OWNER TO postgres;

--
-- Name: gorusoneri_gorusoneriid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.gorusoneri_gorusoneriid_seq OWNED BY public.gorusoneri.gorusoneriid;


--
-- Name: hasta; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.hasta (
    kisiid integer NOT NULL,
    sigortaid integer
);


ALTER TABLE public.hasta OWNER TO postgres;

--
-- Name: hemsire; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.hemsire (
    kisiid integer NOT NULL,
    pozisyon character varying(40) NOT NULL,
    maas integer NOT NULL
);


ALTER TABLE public.hemsire OWNER TO postgres;

--
-- Name: ilac; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ilac (
    ilacid integer NOT NULL,
    isim character varying(40) NOT NULL,
    marka character varying(30) NOT NULL,
    aciklama character varying(40) NOT NULL
);


ALTER TABLE public.ilac OWNER TO postgres;

--
-- Name: ilac_ilac_ID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."ilac_ilac_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."ilac_ilac_ID_seq" OWNER TO postgres;

--
-- Name: ilac_ilac_ID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."ilac_ilac_ID_seq" OWNED BY public.ilac.ilacid;


--
-- Name: islem; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.islem (
    islemid integer NOT NULL,
    isim character varying(20) NOT NULL,
    ucret double precision NOT NULL,
    aciklama text NOT NULL
);


ALTER TABLE public.islem OWNER TO postgres;

--
-- Name: islem_islemid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.islem_islemid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.islem_islemid_seq OWNER TO postgres;

--
-- Name: islem_islemid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.islem_islemid_seq OWNED BY public.islem.islemid;


--
-- Name: islemekipman; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.islemekipman (
    islemid integer NOT NULL,
    ekipmanid integer NOT NULL
);


ALTER TABLE public.islemekipman OWNER TO postgres;

--
-- Name: kisi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kisi (
    kisiid integer NOT NULL,
    isim character varying(20) NOT NULL,
    soyisim character varying(20) NOT NULL,
    tcno character varying(11) NOT NULL,
    dogumtarihi date NOT NULL,
    cinsiyet character varying(10) NOT NULL,
    telno character varying(15) NOT NULL,
    doktor boolean,
    hasta boolean,
    yonetim boolean,
    hemsire boolean
);


ALTER TABLE public.kisi OWNER TO postgres;

--
-- Name: kisi_kisiid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.kisi_kisiid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.kisi_kisiid_seq OWNER TO postgres;

--
-- Name: kisi_kisiid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.kisi_kisiid_seq OWNED BY public.kisi.kisiid;


--
-- Name: randevu; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.randevu (
    randevuid integer NOT NULL,
    doktorid integer NOT NULL,
    hastaid integer NOT NULL,
    tarih date NOT NULL,
    saat time without time zone NOT NULL
);


ALTER TABLE public.randevu OWNER TO postgres;

--
-- Name: randevu_randevu_ID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."randevu_randevu_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."randevu_randevu_ID_seq" OWNER TO postgres;

--
-- Name: randevu_randevu_ID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."randevu_randevu_ID_seq" OWNED BY public.randevu.randevuid;


--
-- Name: recete; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.recete (
    receteid integer NOT NULL,
    doz text NOT NULL,
    kullanimsikligi text NOT NULL,
    aciklama text NOT NULL,
    tedaviid integer NOT NULL
);


ALTER TABLE public.recete OWNER TO postgres;

--
-- Name: recete_receteid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.recete_receteid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.recete_receteid_seq OWNER TO postgres;

--
-- Name: recete_receteid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.recete_receteid_seq OWNED BY public.recete.receteid;


--
-- Name: receteilac; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.receteilac (
    receteid integer NOT NULL,
    ilacid integer NOT NULL
);


ALTER TABLE public.receteilac OWNER TO postgres;

--
-- Name: sigorta; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.sigorta (
    sigortaid integer NOT NULL,
    isim character varying(20) NOT NULL,
    telno character varying(15) NOT NULL,
    adress character varying(40) NOT NULL,
    mersisno character varying(16) NOT NULL
);


ALTER TABLE public.sigorta OWNER TO postgres;

--
-- Name: sigorta_sigorta_ID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."sigorta_sigorta_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."sigorta_sigorta_ID_seq" OWNER TO postgres;

--
-- Name: sigorta_sigorta_ID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."sigorta_sigorta_ID_seq" OWNED BY public.sigorta.sigortaid;


--
-- Name: tedavi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tedavi (
    tedaviid integer NOT NULL,
    doktorid integer NOT NULL,
    hastaid integer NOT NULL,
    tarih date NOT NULL,
    aciklama text NOT NULL,
    ucret integer NOT NULL,
    hemsireid integer
);


ALTER TABLE public.tedavi OWNER TO postgres;

--
-- Name: tedavi_tedaviid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tedavi_tedaviid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tedavi_tedaviid_seq OWNER TO postgres;

--
-- Name: tedavi_tedaviid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tedavi_tedaviid_seq OWNED BY public.tedavi.tedaviid;


--
-- Name: tedaviislem; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tedaviislem (
    islemid integer NOT NULL,
    tedaviid integer NOT NULL
);


ALTER TABLE public.tedaviislem OWNER TO postgres;

--
-- Name: urunfiyatdegisim; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.urunfiyatdegisim (
    urunfiyatdegisimiid integer NOT NULL,
    urunid integer NOT NULL,
    "eskiBirimFiyat" real NOT NULL,
    "yeniBirimFiyat" real NOT NULL,
    "degisiklilikTarihi" timestamp without time zone NOT NULL
);


ALTER TABLE public.urunfiyatdegisim OWNER TO postgres;

--
-- Name: urunFiyatDegisim_urunFiyatDegisimi_ID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."urunFiyatDegisim_urunFiyatDegisimi_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."urunFiyatDegisim_urunFiyatDegisimi_ID_seq" OWNER TO postgres;

--
-- Name: urunFiyatDegisim_urunFiyatDegisimi_ID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."urunFiyatDegisim_urunFiyatDegisimi_ID_seq" OWNED BY public.urunfiyatdegisim.urunfiyatdegisimiid;


--
-- Name: duyurular duyuruid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.duyurular ALTER COLUMN duyuruid SET DEFAULT nextval('public.duyurular_duyuruid_seq'::regclass);


--
-- Name: ekipman ekipmanid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ekipman ALTER COLUMN ekipmanid SET DEFAULT nextval('public."ekipman_ekipman_ID_seq"'::regclass);


--
-- Name: envanter urunid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.envanter ALTER COLUMN urunid SET DEFAULT nextval('public."envanter_urun_ID_seq"'::regclass);


--
-- Name: gorusoneri gorusoneriid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.gorusoneri ALTER COLUMN gorusoneriid SET DEFAULT nextval('public.gorusoneri_gorusoneriid_seq'::regclass);


--
-- Name: ilac ilacid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ilac ALTER COLUMN ilacid SET DEFAULT nextval('public."ilac_ilac_ID_seq"'::regclass);


--
-- Name: islem islemid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.islem ALTER COLUMN islemid SET DEFAULT nextval('public.islem_islemid_seq'::regclass);


--
-- Name: kisi kisiid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kisi ALTER COLUMN kisiid SET DEFAULT nextval('public.kisi_kisiid_seq'::regclass);


--
-- Name: randevu randevuid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.randevu ALTER COLUMN randevuid SET DEFAULT nextval('public."randevu_randevu_ID_seq"'::regclass);


--
-- Name: recete receteid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.recete ALTER COLUMN receteid SET DEFAULT nextval('public.recete_receteid_seq'::regclass);


--
-- Name: sigorta sigortaid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sigorta ALTER COLUMN sigortaid SET DEFAULT nextval('public."sigorta_sigorta_ID_seq"'::regclass);


--
-- Name: tedavi tedaviid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tedavi ALTER COLUMN tedaviid SET DEFAULT nextval('public.tedavi_tedaviid_seq'::regclass);


--
-- Name: urunfiyatdegisim urunfiyatdegisimiid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urunfiyatdegisim ALTER COLUMN urunfiyatdegisimiid SET DEFAULT nextval('public."urunFiyatDegisim_urunFiyatDegisimi_ID_seq"'::regclass);


--
-- Data for Name: doktor; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.doktor VALUES
	(15, 'off artık cidden', 3000575);


--
-- Data for Name: duyurular; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ekipman; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.ekipman VALUES
	(1, 'fatih ekipman', 'asd', '15 hafta', 'samsn', 1),
	(2, 'bicak', 'A85', '1 yıl', 'bicak san.', 4),
	(3, 'makas', 'keskin burun', '2 ay', 'makas san.', 5),
	(4, 'igne', 'ince uc.', 'yoktur. tek kullanımlık.', 'makas san.', 6);


--
-- Data for Name: envanter; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.envanter VALUES
	(1, 10, 'fatihh', 25),
	(2, 25, 'asude ltd', 487),
	(3, 5, 'samsn', 57),
	(4, 5, 'bicak ted.', 15),
	(5, 200, 'makas ted.', 20),
	(6, 2000, 'iğne ted.', 1);


--
-- Data for Name: gorusoneri; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.gorusoneri VALUES
	(1, 'elif', 'gözlemci', 'Hastaneye asik oldm', 'cok ii mutlaka hastalnın gelin');


--
-- Data for Name: hasta; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.hasta VALUES
	(8, 0);


--
-- Data for Name: hemsire; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.hemsire VALUES
	(13, 'yan isci', 3640),
	(0, 'NULL', 0);


--
-- Data for Name: ilac; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.ilac VALUES
	(6, 'milka', 'danone', 'muzlu cikolata'),
	(1, 'parol', 'abdi ibraho', 'agri'),
	(2, 'mazejik', 'bayer', 'agri');


--
-- Data for Name: islem; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.islem VALUES
	(1, 'keskin', 5, 'kesici alettt'),
	(3, 'dikis(buyuk)', 15, 'buyuk yaraları kapatmak icin'),
	(2, 'dikis', 10, 'kucuk yaraları kapatmak icin'),
	(6, 'ekipman deneme', 30, 'ekipman deniyorz');


--
-- Data for Name: islemekipman; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.islemekipman VALUES
	(6, 3),
	(6, 4);


--
-- Data for Name: kisi; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.kisi VALUES
	(8, 'fatih', 'türkel', '12354557855', '2022-12-01', 'Erkek', '54', NULL, true, NULL, NULL),
	(14, 'ayse', 'duzduran', '49823844163', '2022-07-06', 'Kadın', '165', NULL, NULL, NULL, true),
	(13, 'fatma', 'off', '36914725835', '2022-12-09', 'Kadın', '+4635215', NULL, NULL, NULL, true),
	(15, 'uyvar', 'türkel', '12345679826', '2022-12-02', 'Erkek', '+547687', true, NULL, NULL, NULL),
	(0, 'NULL', 'NULL', 'NULL', '1970-01-01', 'NULL', 'NULL', true, true, true, true),
	(16, 'ahmet', 'erkan', '14785236945', '2020-02-04', 'Erkek', '+15612', true, NULL, NULL, NULL);


--
-- Data for Name: randevu; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.randevu VALUES
	(2, 15, 8, '2022-12-16', '14:25:00');


--
-- Data for Name: recete; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.recete VALUES
	(1, '1 mg', '12 saate 1', 'tok karına alınsın ', 4),
	(2, '2 mg', '6 saate 1', 'Sık ', 4);


--
-- Data for Name: receteilac; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.receteilac VALUES
	(2, 1),
	(2, 2);


--
-- Data for Name: sigorta; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.sigorta VALUES
	(5, 'asude', '3659', '12', 'kirikale'),
	(0, 'Yok', 'Null', 'Null', 'Null');


--
-- Data for Name: tedavi; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tedavi VALUES
	(4, 15, 8, '2022-12-09', 'hasta iylesti', 100, 0),
	(9, 15, 8, '2022-12-15', 'tekrar hastlanmsn', 215, NULL);


--
-- Data for Name: tedaviislem; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.tedaviislem VALUES
	(6, 4);


--
-- Data for Name: urunfiyatdegisim; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.urunfiyatdegisim VALUES
	(1, 1, 15, 20, '2022-12-15 14:21:29.772288'),
	(2, 1, 20, 25, '2022-12-15 14:22:44.069828'),
	(3, 3, 10, 57, '2022-12-24 13:46:33.959255');


--
-- Name: duyurular_duyuruid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.duyurular_duyuruid_seq', 1, false);


--
-- Name: ekipman_ekipman_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."ekipman_ekipman_ID_seq"', 4, true);


--
-- Name: envanter_urun_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."envanter_urun_ID_seq"', 6, true);


--
-- Name: gorusoneri_gorusoneriid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.gorusoneri_gorusoneriid_seq', 1, true);


--
-- Name: ilac_ilac_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."ilac_ilac_ID_seq"', 6, true);


--
-- Name: islem_islemid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.islem_islemid_seq', 6, true);


--
-- Name: kisi_kisiid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.kisi_kisiid_seq', 16, true);


--
-- Name: randevu_randevu_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."randevu_randevu_ID_seq"', 2, true);


--
-- Name: recete_receteid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.recete_receteid_seq', 2, true);


--
-- Name: sigorta_sigorta_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."sigorta_sigorta_ID_seq"', 12, true);


--
-- Name: tedavi_tedaviid_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tedavi_tedaviid_seq', 9, true);


--
-- Name: urunFiyatDegisim_urunFiyatDegisimi_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."urunFiyatDegisim_urunFiyatDegisimi_ID_seq"', 5, true);


--
-- Name: doktor doktor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.doktor
    ADD CONSTRAINT doktor_pkey PRIMARY KEY (kisiid);


--
-- Name: duyurular duyurular_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.duyurular
    ADD CONSTRAINT duyurular_pkey PRIMARY KEY (duyuruid);


--
-- Name: ekipman ekipman_ekipman_ID_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ekipman
    ADD CONSTRAINT "ekipman_ekipman_ID_key" UNIQUE (ekipmanid);


--
-- Name: ekipman ekipman_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ekipman
    ADD CONSTRAINT ekipman_pkey PRIMARY KEY (ekipmanid, urunid);


--
-- Name: envanter envanter_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.envanter
    ADD CONSTRAINT envanter_pkey PRIMARY KEY (urunid);


--
-- Name: gorusoneri gorusoneri_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.gorusoneri
    ADD CONSTRAINT gorusoneri_pkey PRIMARY KEY (gorusoneriid);


--
-- Name: hasta hasta_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hasta
    ADD CONSTRAINT hasta_pkey PRIMARY KEY (kisiid);


--
-- Name: hemsire hemsire_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hemsire
    ADD CONSTRAINT hemsire_pkey PRIMARY KEY (kisiid);


--
-- Name: ilac ilac_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ilac
    ADD CONSTRAINT ilac_pkey PRIMARY KEY (ilacid);


--
-- Name: islemekipman islemEkipman_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.islemekipman
    ADD CONSTRAINT "islemEkipman_pkey" PRIMARY KEY (islemid, ekipmanid);


--
-- Name: islem islem_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.islem
    ADD CONSTRAINT islem_pkey PRIMARY KEY (islemid);


--
-- Name: kisi kisi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kisi
    ADD CONSTRAINT kisi_pkey PRIMARY KEY (kisiid);


--
-- Name: randevu randevu_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.randevu
    ADD CONSTRAINT randevu_pkey PRIMARY KEY (randevuid);


--
-- Name: receteilac receteIlac_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.receteilac
    ADD CONSTRAINT "receteIlac_pkey" PRIMARY KEY (receteid, ilacid);


--
-- Name: recete recete_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.recete
    ADD CONSTRAINT recete_pkey PRIMARY KEY (receteid);


--
-- Name: sigorta sigorta_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sigorta
    ADD CONSTRAINT sigorta_pkey PRIMARY KEY (sigortaid);


--
-- Name: tedaviislem tedaviIslem_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tedaviislem
    ADD CONSTRAINT "tedaviIslem_pkey" PRIMARY KEY (islemid, tedaviid);


--
-- Name: tedavi tedavi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tedavi
    ADD CONSTRAINT tedavi_pkey PRIMARY KEY (tedaviid);


--
-- Name: islem unique_islem_isim; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.islem
    ADD CONSTRAINT unique_islem_isim UNIQUE (isim);


--
-- Name: kisi unique_kisi_tcNo; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kisi
    ADD CONSTRAINT "unique_kisi_tcNo" UNIQUE (tcno);


--
-- Name: sigorta unique_sigorta_mersisNo; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sigorta
    ADD CONSTRAINT "unique_sigorta_mersisNo" UNIQUE (mersisno);


--
-- Name: urunfiyatdegisim urunFiyatDegisim_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urunfiyatdegisim
    ADD CONSTRAINT "urunFiyatDegisim_pkey" PRIMARY KEY (urunfiyatdegisimiid);


--
-- Name: envanter urunBirimFiyatDegistiginde; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER "urunBirimFiyatDegistiginde" BEFORE UPDATE ON public.envanter FOR EACH ROW EXECUTE FUNCTION public."urunFiyatDegisimKaydi"();


--
-- Name: randevu doktor_randevu_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.randevu
    ADD CONSTRAINT "doktor_randevu_FK" FOREIGN KEY (doktorid) REFERENCES public.doktor(kisiid) MATCH FULL;


--
-- Name: CONSTRAINT "doktor_randevu_FK" ON randevu; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "doktor_randevu_FK" ON public.randevu IS 'doktor-randevu fk bağlantısı';


--
-- Name: tedavi doktor_tedavi_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tedavi
    ADD CONSTRAINT "doktor_tedavi_FK" FOREIGN KEY (doktorid) REFERENCES public.doktor(kisiid) MATCH FULL;


--
-- Name: CONSTRAINT "doktor_tedavi_FK" ON tedavi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "doktor_tedavi_FK" ON public.tedavi IS 'doktor-tedavi fk bağlantısı';


--
-- Name: islemekipman ekipman_islemEkipman_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.islemekipman
    ADD CONSTRAINT "ekipman_islemEkipman_FK" FOREIGN KEY (ekipmanid) REFERENCES public.ekipman(ekipmanid) MATCH FULL;


--
-- Name: ekipman envanter_ekipman_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ekipman
    ADD CONSTRAINT "envanter_ekipman_FK" FOREIGN KEY (urunid) REFERENCES public.envanter(urunid) MATCH FULL;


--
-- Name: urunfiyatdegisim envanter_urunFiyatDegisimi_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.urunfiyatdegisim
    ADD CONSTRAINT "envanter_urunFiyatDegisimi_FK" FOREIGN KEY (urunid) REFERENCES public.envanter(urunid) MATCH FULL;


--
-- Name: randevu hasta_randevu_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.randevu
    ADD CONSTRAINT "hasta_randevu_FK" FOREIGN KEY (hastaid) REFERENCES public.hasta(kisiid) MATCH FULL;


--
-- Name: CONSTRAINT "hasta_randevu_FK" ON randevu; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "hasta_randevu_FK" ON public.randevu IS 'hasta-randevu fk bağlantısı';


--
-- Name: tedavi hasta_tedavi_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tedavi
    ADD CONSTRAINT "hasta_tedavi_FK" FOREIGN KEY (hastaid) REFERENCES public.hasta(kisiid) MATCH FULL;


--
-- Name: CONSTRAINT "hasta_tedavi_FK" ON tedavi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "hasta_tedavi_FK" ON public.tedavi IS 'hasta-tedavi fk bağlantısı';


--
-- Name: tedavi hemsire_tedavi_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tedavi
    ADD CONSTRAINT "hemsire_tedavi_FK" FOREIGN KEY (hemsireid) REFERENCES public.hemsire(kisiid) MATCH FULL;


--
-- Name: receteilac ilac_receteIlac_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.receteilac
    ADD CONSTRAINT "ilac_receteIlac_FK" FOREIGN KEY (ilacid) REFERENCES public.ilac(ilacid) MATCH FULL;


--
-- Name: islemekipman islem_islemEkipman_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.islemekipman
    ADD CONSTRAINT "islem_islemEkipman_FK" FOREIGN KEY (islemid) REFERENCES public.islem(islemid) MATCH FULL;


--
-- Name: tedaviislem islem_tedaviIslem_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tedaviislem
    ADD CONSTRAINT "islem_tedaviIslem_FK" FOREIGN KEY (islemid) REFERENCES public.islem(islemid) MATCH FULL;


--
-- Name: doktor kisi_doktor_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.doktor
    ADD CONSTRAINT "kisi_doktor_FK" FOREIGN KEY (kisiid) REFERENCES public.kisi(kisiid) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: CONSTRAINT "kisi_doktor_FK" ON doktor; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "kisi_doktor_FK" ON public.doktor IS 'kisi doktor arasındaki fk bağlantısı';


--
-- Name: hasta kisi_hasta_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hasta
    ADD CONSTRAINT "kisi_hasta_FK" FOREIGN KEY (kisiid) REFERENCES public.kisi(kisiid) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: CONSTRAINT "kisi_hasta_FK" ON hasta; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "kisi_hasta_FK" ON public.hasta IS 'kisi-hasta fk bağlantısı';


--
-- Name: hemsire kisi_hemsire_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hemsire
    ADD CONSTRAINT "kisi_hemsire_FK" FOREIGN KEY (kisiid) REFERENCES public.kisi(kisiid) MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: CONSTRAINT "kisi_hemsire_FK" ON hemsire; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "kisi_hemsire_FK" ON public.hemsire IS 'kisi hemsire arasındaki fk';


--
-- Name: receteilac recete_receteIlac_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.receteilac
    ADD CONSTRAINT "recete_receteIlac_FK" FOREIGN KEY (receteid) REFERENCES public.recete(receteid) MATCH FULL;


--
-- Name: hasta sigorta_hasta_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hasta
    ADD CONSTRAINT "sigorta_hasta_FK" FOREIGN KEY (sigortaid) REFERENCES public.sigorta(sigortaid) MATCH FULL;


--
-- Name: CONSTRAINT "sigorta_hasta_FK" ON hasta; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "sigorta_hasta_FK" ON public.hasta IS 'sigorta ile hasta arasındaki fk bağlantısı';


--
-- Name: recete tedavi_recete_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.recete
    ADD CONSTRAINT "tedavi_recete_FK" FOREIGN KEY (tedaviid) REFERENCES public.tedavi(tedaviid) MATCH FULL;


--
-- Name: tedaviislem tedavi_tedaviIslem_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tedaviislem
    ADD CONSTRAINT "tedavi_tedaviIslem_FK" FOREIGN KEY (tedaviid) REFERENCES public.tedavi(tedaviid) MATCH FULL;


--
-- PostgreSQL database dump complete
--

