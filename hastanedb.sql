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
    "kisi_ID" integer NOT NULL,
    pozisyon character varying(40) NOT NULL,
    maas double precision NOT NULL,
    "poliklinik_ID" integer NOT NULL
);


ALTER TABLE public.doktor OWNER TO postgres;

--
-- Name: ekipman; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ekipman (
    "ekipman_ID" integer NOT NULL,
    isim character varying(40) NOT NULL,
    "modelNumarasi" character varying(40) NOT NULL,
    ucret double precision NOT NULL,
    "bakimSikligi" text NOT NULL,
    uretici character varying(40) NOT NULL,
    "urun_ID" integer NOT NULL
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

ALTER SEQUENCE public."ekipman_ekipman_ID_seq" OWNED BY public.ekipman."ekipman_ID";


--
-- Name: envanter; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.envanter (
    "urun_ID" integer NOT NULL,
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

ALTER SEQUENCE public."envanter_urun_ID_seq" OWNED BY public.envanter."urun_ID";


--
-- Name: hasta; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.hasta (
    "kisi_ID" integer NOT NULL,
    "sigorta_ID" integer NOT NULL
);


ALTER TABLE public.hasta OWNER TO postgres;

--
-- Name: hemsire; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.hemsire (
    "kisi_ID" integer NOT NULL,
    pozisyon character varying(40) NOT NULL,
    maas double precision NOT NULL
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
    "islem_ID" integer NOT NULL,
    isim character varying(20) NOT NULL,
    ucret double precision NOT NULL,
    aciklama text NOT NULL
);


ALTER TABLE public.islem OWNER TO postgres;

--
-- Name: islemEkipman; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."islemEkipman" (
    "islem_ID" integer NOT NULL,
    "ekipman_ID" integer NOT NULL
);


ALTER TABLE public."islemEkipman" OWNER TO postgres;

--
-- Name: islem_islem_ID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."islem_islem_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."islem_islem_ID_seq" OWNER TO postgres;

--
-- Name: islem_islem_ID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."islem_islem_ID_seq" OWNED BY public.islem."islem_ID";


--
-- Name: kisi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kisi (
    "kisi_ID" integer NOT NULL,
    isim character varying(20) NOT NULL,
    soyisim character varying(20) NOT NULL,
    "tcNo" character varying(11) NOT NULL,
    "dogumTarihi" date NOT NULL,
    cinsiyet character varying(5) NOT NULL,
    "telNo" character varying(11) NOT NULL,
    doktor boolean NOT NULL,
    hasta boolean NOT NULL,
    yonetim boolean NOT NULL,
    hemsire boolean NOT NULL
);


ALTER TABLE public.kisi OWNER TO postgres;

--
-- Name: kisi_kisi_ID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."kisi_kisi_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."kisi_kisi_ID_seq" OWNER TO postgres;

--
-- Name: kisi_kisi_ID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."kisi_kisi_ID_seq" OWNED BY public.kisi."kisi_ID";


--
-- Name: poliklinik; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.poliklinik (
    "poliklinik_ID" integer NOT NULL,
    isim character varying(40) NOT NULL,
    "telNo" character varying(15) NOT NULL,
    adres character varying(40) NOT NULL,
    "acıklama" text,
    yonetici integer NOT NULL
);


ALTER TABLE public.poliklinik OWNER TO postgres;

--
-- Name: poliklinik_poliklinik_ID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."poliklinik_poliklinik_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."poliklinik_poliklinik_ID_seq" OWNER TO postgres;

--
-- Name: poliklinik_poliklinik_ID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."poliklinik_poliklinik_ID_seq" OWNED BY public.poliklinik."poliklinik_ID";


--
-- Name: randevu; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.randevu (
    "randevu_ID" integer NOT NULL,
    "doktor_ID" integer NOT NULL,
    "hasta_ID" integer NOT NULL,
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

ALTER SEQUENCE public."randevu_randevu_ID_seq" OWNED BY public.randevu."randevu_ID";


--
-- Name: recete; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.recete (
    "recete_ID" integer NOT NULL,
    doz text NOT NULL,
    "kullanimSikligi" text NOT NULL,
    "ekAciklama" text NOT NULL,
    "tedavi_ID" integer NOT NULL
);


ALTER TABLE public.recete OWNER TO postgres;

--
-- Name: receteIlac; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."receteIlac" (
    "recete_ID" integer NOT NULL,
    "ilac_ID" integer NOT NULL
);


ALTER TABLE public."receteIlac" OWNER TO postgres;

--
-- Name: recete_recete_ID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."recete_recete_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."recete_recete_ID_seq" OWNER TO postgres;

--
-- Name: recete_recete_ID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."recete_recete_ID_seq" OWNED BY public.recete."recete_ID";


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
    "tedavi_ID" integer NOT NULL,
    "doktor_ID" integer NOT NULL,
    "hasta_ID" integer NOT NULL,
    tarih date NOT NULL,
    aciklama text NOT NULL,
    ucret double precision NOT NULL
);


ALTER TABLE public.tedavi OWNER TO postgres;

--
-- Name: tedaviHemsire; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."tedaviHemsire" (
    "hemsire_ID" integer NOT NULL,
    "tedavi_ID" integer NOT NULL
);


ALTER TABLE public."tedaviHemsire" OWNER TO postgres;

--
-- Name: tedaviIslem; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."tedaviIslem" (
    "islem_ID" integer NOT NULL,
    "tedavi_ID" integer NOT NULL
);


ALTER TABLE public."tedaviIslem" OWNER TO postgres;

--
-- Name: tedavi_tedavi_ID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."tedavi_tedavi_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."tedavi_tedavi_ID_seq" OWNER TO postgres;

--
-- Name: tedavi_tedavi_ID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."tedavi_tedavi_ID_seq" OWNED BY public.tedavi."tedavi_ID";


--
-- Name: urunFiyatDegisim; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."urunFiyatDegisim" (
    "urunFiyatDegisimi_ID" integer NOT NULL,
    "urun_ID" integer NOT NULL,
    "eskiBirimFiyat" real NOT NULL,
    "yeniBirimFiyat" real NOT NULL,
    "degisiklilikTarihi" timestamp without time zone NOT NULL
);


ALTER TABLE public."urunFiyatDegisim" OWNER TO postgres;

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

ALTER SEQUENCE public."urunFiyatDegisim_urunFiyatDegisimi_ID_seq" OWNED BY public."urunFiyatDegisim"."urunFiyatDegisimi_ID";


--
-- Name: yonetim; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.yonetim (
    "kisi_ID" integer NOT NULL,
    "pozisyon " character varying(20) NOT NULL,
    maas double precision NOT NULL
);


ALTER TABLE public.yonetim OWNER TO postgres;

--
-- Name: ekipman ekipman_ID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ekipman ALTER COLUMN "ekipman_ID" SET DEFAULT nextval('public."ekipman_ekipman_ID_seq"'::regclass);


--
-- Name: envanter urun_ID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.envanter ALTER COLUMN "urun_ID" SET DEFAULT nextval('public."envanter_urun_ID_seq"'::regclass);


--
-- Name: ilac ilacid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ilac ALTER COLUMN ilacid SET DEFAULT nextval('public."ilac_ilac_ID_seq"'::regclass);


--
-- Name: islem islem_ID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.islem ALTER COLUMN "islem_ID" SET DEFAULT nextval('public."islem_islem_ID_seq"'::regclass);


--
-- Name: kisi kisi_ID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kisi ALTER COLUMN "kisi_ID" SET DEFAULT nextval('public."kisi_kisi_ID_seq"'::regclass);


--
-- Name: poliklinik poliklinik_ID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.poliklinik ALTER COLUMN "poliklinik_ID" SET DEFAULT nextval('public."poliklinik_poliklinik_ID_seq"'::regclass);


--
-- Name: randevu randevu_ID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.randevu ALTER COLUMN "randevu_ID" SET DEFAULT nextval('public."randevu_randevu_ID_seq"'::regclass);


--
-- Name: recete recete_ID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.recete ALTER COLUMN "recete_ID" SET DEFAULT nextval('public."recete_recete_ID_seq"'::regclass);


--
-- Name: sigorta sigortaid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sigorta ALTER COLUMN sigortaid SET DEFAULT nextval('public."sigorta_sigorta_ID_seq"'::regclass);


--
-- Name: tedavi tedavi_ID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tedavi ALTER COLUMN "tedavi_ID" SET DEFAULT nextval('public."tedavi_tedavi_ID_seq"'::regclass);


--
-- Name: urunFiyatDegisim urunFiyatDegisimi_ID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."urunFiyatDegisim" ALTER COLUMN "urunFiyatDegisimi_ID" SET DEFAULT nextval('public."urunFiyatDegisim_urunFiyatDegisimi_ID_seq"'::regclass);


--
-- Data for Name: doktor; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ekipman; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: envanter; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.envanter VALUES
	(1, 10, 'fatihh', 25),
	(2, 25, 'asude ltd', 487);


--
-- Data for Name: hasta; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: hemsire; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ilac; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.ilac VALUES
	(1, 'isim:', 'parol', 'agri '),
	(2, 'isim:', 'majezik', 'agri'),
	(3, 'isim:', '', ''),
	(4, 'isim:', 'fatşhsan', 'yep yepni');


--
-- Data for Name: islem; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: islemEkipman; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: kisi; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: poliklinik; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: randevu; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: recete; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: receteIlac; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: sigorta; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.sigorta VALUES
	(5, 'asude', '345', 'kırıkkale', '12');


--
-- Data for Name: tedavi; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: tedaviHemsire; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: tedaviIslem; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: urunFiyatDegisim; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."urunFiyatDegisim" VALUES
	(1, 1, 15, 20, '2022-12-15 14:21:29.772288'),
	(2, 1, 20, 25, '2022-12-15 14:22:44.069828');


--
-- Data for Name: yonetim; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Name: ekipman_ekipman_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."ekipman_ekipman_ID_seq"', 1, false);


--
-- Name: envanter_urun_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."envanter_urun_ID_seq"', 2, true);


--
-- Name: ilac_ilac_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."ilac_ilac_ID_seq"', 4, true);


--
-- Name: islem_islem_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."islem_islem_ID_seq"', 1, false);


--
-- Name: kisi_kisi_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."kisi_kisi_ID_seq"', 1, false);


--
-- Name: poliklinik_poliklinik_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."poliklinik_poliklinik_ID_seq"', 1, false);


--
-- Name: randevu_randevu_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."randevu_randevu_ID_seq"', 1, false);


--
-- Name: recete_recete_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."recete_recete_ID_seq"', 1, false);


--
-- Name: sigorta_sigorta_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."sigorta_sigorta_ID_seq"', 11, true);


--
-- Name: tedavi_tedavi_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."tedavi_tedavi_ID_seq"', 1, false);


--
-- Name: urunFiyatDegisim_urunFiyatDegisimi_ID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."urunFiyatDegisim_urunFiyatDegisimi_ID_seq"', 2, true);


--
-- Name: doktor doktor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.doktor
    ADD CONSTRAINT doktor_pkey PRIMARY KEY ("kisi_ID");


--
-- Name: ekipman ekipman_ekipman_ID_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ekipman
    ADD CONSTRAINT "ekipman_ekipman_ID_key" UNIQUE ("ekipman_ID");


--
-- Name: ekipman ekipman_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ekipman
    ADD CONSTRAINT ekipman_pkey PRIMARY KEY ("ekipman_ID", "urun_ID");


--
-- Name: envanter envanter_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.envanter
    ADD CONSTRAINT envanter_pkey PRIMARY KEY ("urun_ID");


--
-- Name: hasta hasta_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hasta
    ADD CONSTRAINT hasta_pkey PRIMARY KEY ("kisi_ID");


--
-- Name: hemsire hemsire_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hemsire
    ADD CONSTRAINT hemsire_pkey PRIMARY KEY ("kisi_ID");


--
-- Name: ilac ilac_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ilac
    ADD CONSTRAINT ilac_pkey PRIMARY KEY (ilacid);


--
-- Name: islemEkipman islemEkipman_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."islemEkipman"
    ADD CONSTRAINT "islemEkipman_pkey" PRIMARY KEY ("islem_ID", "ekipman_ID");


--
-- Name: islem islem_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.islem
    ADD CONSTRAINT islem_pkey PRIMARY KEY ("islem_ID");


--
-- Name: kisi kisi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kisi
    ADD CONSTRAINT kisi_pkey PRIMARY KEY ("kisi_ID");


--
-- Name: poliklinik poliklinik_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.poliklinik
    ADD CONSTRAINT poliklinik_pkey PRIMARY KEY ("poliklinik_ID");


--
-- Name: randevu randevu_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.randevu
    ADD CONSTRAINT randevu_pkey PRIMARY KEY ("randevu_ID");


--
-- Name: receteIlac receteIlac_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."receteIlac"
    ADD CONSTRAINT "receteIlac_pkey" PRIMARY KEY ("recete_ID", "ilac_ID");


--
-- Name: recete recete_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.recete
    ADD CONSTRAINT recete_pkey PRIMARY KEY ("recete_ID");


--
-- Name: sigorta sigorta_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sigorta
    ADD CONSTRAINT sigorta_pkey PRIMARY KEY (sigortaid);


--
-- Name: tedaviHemsire tedaviHemsire_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."tedaviHemsire"
    ADD CONSTRAINT "tedaviHemsire_pkey" PRIMARY KEY ("hemsire_ID", "tedavi_ID");


--
-- Name: tedaviIslem tedaviIslem_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."tedaviIslem"
    ADD CONSTRAINT "tedaviIslem_pkey" PRIMARY KEY ("islem_ID", "tedavi_ID");


--
-- Name: tedavi tedavi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tedavi
    ADD CONSTRAINT tedavi_pkey PRIMARY KEY ("tedavi_ID");


--
-- Name: islem unique_islem_isim; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.islem
    ADD CONSTRAINT unique_islem_isim UNIQUE (isim);


--
-- Name: kisi unique_kisi_tcNo; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kisi
    ADD CONSTRAINT "unique_kisi_tcNo" UNIQUE ("tcNo");


--
-- Name: sigorta unique_sigorta_mersisNo; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sigorta
    ADD CONSTRAINT "unique_sigorta_mersisNo" UNIQUE (mersisno);


--
-- Name: urunFiyatDegisim urunFiyatDegisim_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."urunFiyatDegisim"
    ADD CONSTRAINT "urunFiyatDegisim_pkey" PRIMARY KEY ("urunFiyatDegisimi_ID");


--
-- Name: yonetim yonetim_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.yonetim
    ADD CONSTRAINT yonetim_pkey PRIMARY KEY ("kisi_ID");


--
-- Name: envanter urunBirimFiyatDegistiginde; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER "urunBirimFiyatDegistiginde" BEFORE UPDATE ON public.envanter FOR EACH ROW EXECUTE FUNCTION public."urunFiyatDegisimKaydi"();


--
-- Name: randevu doktor_randevu_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.randevu
    ADD CONSTRAINT "doktor_randevu_FK" FOREIGN KEY ("doktor_ID") REFERENCES public.doktor("kisi_ID") MATCH FULL;


--
-- Name: CONSTRAINT "doktor_randevu_FK" ON randevu; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "doktor_randevu_FK" ON public.randevu IS 'doktor-randevu fk bağlantısı';


--
-- Name: tedavi doktor_tedavi_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tedavi
    ADD CONSTRAINT "doktor_tedavi_FK" FOREIGN KEY ("doktor_ID") REFERENCES public.doktor("kisi_ID") MATCH FULL;


--
-- Name: CONSTRAINT "doktor_tedavi_FK" ON tedavi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "doktor_tedavi_FK" ON public.tedavi IS 'doktor-tedavi fk bağlantısı';


--
-- Name: islemEkipman ekipman_islemEkipman_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."islemEkipman"
    ADD CONSTRAINT "ekipman_islemEkipman_FK" FOREIGN KEY ("ekipman_ID") REFERENCES public.ekipman("ekipman_ID") MATCH FULL;


--
-- Name: ekipman envanter_ekipman_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ekipman
    ADD CONSTRAINT "envanter_ekipman_FK" FOREIGN KEY ("urun_ID") REFERENCES public.envanter("urun_ID") MATCH FULL;


--
-- Name: urunFiyatDegisim envanter_urunFiyatDegisimi_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."urunFiyatDegisim"
    ADD CONSTRAINT "envanter_urunFiyatDegisimi_FK" FOREIGN KEY ("urun_ID") REFERENCES public.envanter("urun_ID") MATCH FULL;


--
-- Name: randevu hasta_randevu_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.randevu
    ADD CONSTRAINT "hasta_randevu_FK" FOREIGN KEY ("hasta_ID") REFERENCES public.hasta("kisi_ID") MATCH FULL;


--
-- Name: CONSTRAINT "hasta_randevu_FK" ON randevu; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "hasta_randevu_FK" ON public.randevu IS 'hasta-randevu fk bağlantısı';


--
-- Name: tedavi hasta_tedavi_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tedavi
    ADD CONSTRAINT "hasta_tedavi_FK" FOREIGN KEY ("hasta_ID") REFERENCES public.hasta("kisi_ID") MATCH FULL;


--
-- Name: CONSTRAINT "hasta_tedavi_FK" ON tedavi; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "hasta_tedavi_FK" ON public.tedavi IS 'hasta-tedavi fk bağlantısı';


--
-- Name: tedaviHemsire hemsire_tedaviHemsire_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."tedaviHemsire"
    ADD CONSTRAINT "hemsire_tedaviHemsire_FK" FOREIGN KEY ("hemsire_ID") REFERENCES public.hemsire("kisi_ID") MATCH FULL;


--
-- Name: receteIlac ilac_receteIlac_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."receteIlac"
    ADD CONSTRAINT "ilac_receteIlac_FK" FOREIGN KEY ("ilac_ID") REFERENCES public.ilac(ilacid) MATCH FULL;


--
-- Name: islemEkipman islem_islemEkipman_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."islemEkipman"
    ADD CONSTRAINT "islem_islemEkipman_FK" FOREIGN KEY ("islem_ID") REFERENCES public.islem("islem_ID") MATCH FULL;


--
-- Name: tedaviIslem islem_tedaviIslem_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."tedaviIslem"
    ADD CONSTRAINT "islem_tedaviIslem_FK" FOREIGN KEY ("islem_ID") REFERENCES public.islem("islem_ID") MATCH FULL;


--
-- Name: doktor kisi_doktor_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.doktor
    ADD CONSTRAINT "kisi_doktor_FK" FOREIGN KEY ("kisi_ID") REFERENCES public.kisi("kisi_ID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: CONSTRAINT "kisi_doktor_FK" ON doktor; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "kisi_doktor_FK" ON public.doktor IS 'kisi doktor arasındaki fk bağlantısı';


--
-- Name: hasta kisi_hasta_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hasta
    ADD CONSTRAINT "kisi_hasta_FK" FOREIGN KEY ("kisi_ID") REFERENCES public.kisi("kisi_ID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: CONSTRAINT "kisi_hasta_FK" ON hasta; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "kisi_hasta_FK" ON public.hasta IS 'kisi-hasta fk bağlantısı';


--
-- Name: hemsire kisi_hemsire_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hemsire
    ADD CONSTRAINT "kisi_hemsire_FK" FOREIGN KEY ("kisi_ID") REFERENCES public.kisi("kisi_ID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: CONSTRAINT "kisi_hemsire_FK" ON hemsire; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "kisi_hemsire_FK" ON public.hemsire IS 'kisi hemsire arasındaki fk';


--
-- Name: yonetim kisi_yonetim_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.yonetim
    ADD CONSTRAINT "kisi_yonetim_FK" FOREIGN KEY ("kisi_ID") REFERENCES public.kisi("kisi_ID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: CONSTRAINT "kisi_yonetim_FK" ON yonetim; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "kisi_yonetim_FK" ON public.yonetim IS 'kisi-yonetim fk bağlantısı';


--
-- Name: receteIlac recete_receteIlac_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."receteIlac"
    ADD CONSTRAINT "recete_receteIlac_FK" FOREIGN KEY ("recete_ID") REFERENCES public.recete("recete_ID") MATCH FULL;


--
-- Name: hasta sigorta_hasta_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hasta
    ADD CONSTRAINT "sigorta_hasta_FK" FOREIGN KEY ("sigorta_ID") REFERENCES public.sigorta(sigortaid) MATCH FULL;


--
-- Name: CONSTRAINT "sigorta_hasta_FK" ON hasta; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "sigorta_hasta_FK" ON public.hasta IS 'sigorta ile hasta arasındaki fk bağlantısı';


--
-- Name: recete tedavi_recete_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.recete
    ADD CONSTRAINT "tedavi_recete_FK" FOREIGN KEY ("tedavi_ID") REFERENCES public.tedavi("tedavi_ID") MATCH FULL;


--
-- Name: tedaviHemsire tedavi_tedaviHemsire_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."tedaviHemsire"
    ADD CONSTRAINT "tedavi_tedaviHemsire_FK" FOREIGN KEY ("tedavi_ID") REFERENCES public.tedavi("tedavi_ID") MATCH FULL;


--
-- Name: tedaviIslem tedavi_tedaviIslem_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."tedaviIslem"
    ADD CONSTRAINT "tedavi_tedaviIslem_FK" FOREIGN KEY ("tedavi_ID") REFERENCES public.tedavi("tedavi_ID") MATCH FULL;


--
-- Name: poliklinik yonetim_poliklinik_FK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.poliklinik
    ADD CONSTRAINT "yonetim_poliklinik_FK" FOREIGN KEY (yonetici) REFERENCES public.yonetim("kisi_ID") MATCH FULL;


--
-- Name: CONSTRAINT "yonetim_poliklinik_FK" ON poliklinik; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON CONSTRAINT "yonetim_poliklinik_FK" ON public.poliklinik IS 'yonetim-poliklinik fk bağlantısı';


--
-- PostgreSQL database dump complete
--

