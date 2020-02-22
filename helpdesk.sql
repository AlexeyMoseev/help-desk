--
-- PostgreSQL database dump
--

-- Dumped from database version 10.2
-- Dumped by pg_dump version 10.2

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

--
-- Name: delete_category(bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION delete_category(i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update category set del_flag=true where "id"=i;
end;
$$;


ALTER FUNCTION public.delete_category(i bigint) OWNER TO postgres;

--
-- Name: delete_client(bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION delete_client(i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update client set del_flag=true where "id"=i;
end;
$$;


ALTER FUNCTION public.delete_client(i bigint) OWNER TO postgres;

--
-- Name: delete_department(bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION delete_department(i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update department set del_flag=true where "id"=i;
end;
$$;


ALTER FUNCTION public.delete_department(i bigint) OWNER TO postgres;

--
-- Name: delete_post(bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION delete_post(i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update post set del_flag=true where "id"=i;
end;
$$;


ALTER FUNCTION public.delete_post(i bigint) OWNER TO postgres;

--
-- Name: delete_priority(bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION delete_priority(i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update priority set del_flag=true where "id"=i;
end;
$$;


ALTER FUNCTION public.delete_priority(i bigint) OWNER TO postgres;

--
-- Name: delete_request(bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION delete_request(i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update request set del_flag=true where "id"=i;
end;
$$;


ALTER FUNCTION public.delete_request(i bigint) OWNER TO postgres;

--
-- Name: delete_status(bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION delete_status(i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update status set del_flag=true where "id"=i;
end;
$$;


ALTER FUNCTION public.delete_status(i bigint) OWNER TO postgres;

--
-- Name: delete_worker(bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION delete_worker(i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update worker set del_flag=true where "id"=i;
end;
$$;


ALTER FUNCTION public.delete_worker(i bigint) OWNER TO postgres;

--
-- Name: insert_category(character varying, text); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION insert_category(tit character varying, descrip text) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	insert into category(title,description) values (tit,descrip);
end;
$$;


ALTER FUNCTION public.insert_category(tit character varying, descrip text) OWNER TO postgres;

--
-- Name: insert_client(character varying, character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION insert_client(nam character varying, addr character varying, phon character varying, emai character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	insert into client("name",phone,address,email) values (nam,phon,addr,emai);
end;
$$;


ALTER FUNCTION public.insert_client(nam character varying, addr character varying, phon character varying, emai character varying) OWNER TO postgres;

--
-- Name: insert_department(character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION insert_department(tit character varying, phon character varying, emai character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	insert into department(title,phone,email) values (tit,phon,emai);
end;
$$;


ALTER FUNCTION public.insert_department(tit character varying, phon character varying, emai character varying) OWNER TO postgres;

--
-- Name: insert_post(character varying, text); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION insert_post(tit character varying, des text) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	insert into post(title,description) values (tit,des);
end;
$$;


ALTER FUNCTION public.insert_post(tit character varying, des text) OWNER TO postgres;

--
-- Name: insert_priority(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION insert_priority(tit character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	insert into priority(title) values(tit);
end;
$$;


ALTER FUNCTION public.insert_priority(tit character varying) OWNER TO postgres;

--
-- Name: insert_request(character varying, text, date, date, bigint, bigint, bigint, bigint, bigint, bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION insert_request(tit character varying, des text, rec date, dead date, cat bigint, oper bigint, cli bigint, prio bigint, imp bigint, stat bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	insert into request(title,description,date_rec,deadline,id_category,id_operator,id_client,id_priority,id_implementer,id_status)
	values(tit,des,rec,dead,cat,oper,cli,prio,imp,stat);
end;
$$;


ALTER FUNCTION public.insert_request(tit character varying, des text, rec date, dead date, cat bigint, oper bigint, cli bigint, prio bigint, imp bigint, stat bigint) OWNER TO postgres;

--
-- Name: insert_status(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION insert_status(tit character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	insert into status(title) values(tit);
end;
$$;


ALTER FUNCTION public.insert_status(tit character varying) OWNER TO postgres;

--
-- Name: insert_worker(character varying, character varying, character varying, bigint, bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION insert_worker(nam character varying, addr character varying, phon character varying, dep bigint, post bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	insert into worker("name",phone,address,id_department,id_post) values (nam,phon,addr,dep,post);
end;
$$;


ALTER FUNCTION public.insert_worker(nam character varying, addr character varying, phon character varying, dep bigint, post bigint) OWNER TO postgres;

--
-- Name: show_category(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION show_category() RETURNS TABLE("№" bigint, "Наименование" character varying, "Описание" text)
    LANGUAGE plpgsql
    AS $$
begin
	return query
		select "id",title,description from category where del_flag is null or del_flag is false;
end;
$$;


ALTER FUNCTION public.show_category() OWNER TO postgres;

--
-- Name: show_client(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION show_client() RETURNS TABLE("№" bigint, "Имя" character varying, "Адрес" character varying, "Телефон" character varying, "Email" character varying)
    LANGUAGE plpgsql
    AS $$begin
	return query
		select "id","name",address,phone,email from client where del_flag is null or del_flag is false;
end;
$$;


ALTER FUNCTION public.show_client() OWNER TO postgres;

--
-- Name: show_department(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION show_department() RETURNS TABLE("№" bigint, "Наименование" character varying, "Телефон" character varying, "Email" character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
		select "id",title,phone,email from department where del_flag is null or del_flag is false;
end;
$$;


ALTER FUNCTION public.show_department() OWNER TO postgres;

--
-- Name: show_post(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION show_post() RETURNS TABLE("№" bigint, "Наименование" character varying, "Описание" text)
    LANGUAGE plpgsql
    AS $$
begin
	return query
		select "id",title,description from post where del_flag is null or del_flag is false;
end;
$$;


ALTER FUNCTION public.show_post() OWNER TO postgres;

--
-- Name: show_priority(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION show_priority() RETURNS TABLE("№" bigint, "Наименование" character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
		select "id",title from priority where del_flag is null or del_flag is false;
end;
$$;


ALTER FUNCTION public.show_priority() OWNER TO postgres;

--
-- Name: show_request(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION show_request() RETURNS TABLE("№" bigint, "Наименование" character varying, "Описание" text, "Дата приема" date, "Крайний срок" date, "Категория" character varying, "Оператор" character varying, "Клиент" character varying, "Приоритет" character varying, "Исполнитель" character varying, "Статус" character varying)
    LANGUAGE plpgsql
    AS $$begin
	return query
		select request.id, request.title, request.description, request.date_rec, request.deadline, category.title,
		oper.name, client.name,priority.title, imp.name, status.title from request
		inner join category on category.id=request.id_category
		inner join worker as oper on oper.id=request.id_operator
		inner join client on client.id=request.id_client
		inner join priority on priority.id=request.id_priority
		inner join worker as imp on imp.id=request.id_implementer
		inner join status on status.id=request.id_status
		where request.del_flag is null or request.del_flag is false;
end;
$$;


ALTER FUNCTION public.show_request() OWNER TO postgres;

--
-- Name: show_status(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION show_status() RETURNS TABLE("№" bigint, "Наименование" character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
		select "id",title from status where del_flag is null or del_flag is false;
end;
$$;


ALTER FUNCTION public.show_status() OWNER TO postgres;

--
-- Name: show_worker(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION show_worker() RETURNS TABLE("№" bigint, "Имя" character varying, "Адрес" character varying, "Телефон" character varying, "Отдел" character varying, "Должность" character varying)
    LANGUAGE plpgsql
    AS $$begin
	return query
		select worker."id",worker."name",worker.address,worker.phone,department.title,post.title from worker 
		inner join department on department.id=worker.id_department
		inner join post on post.id=worker.id_post
		where worker.del_flag is null or worker.del_flag is false;
end;
$$;


ALTER FUNCTION public.show_worker() OWNER TO postgres;

--
-- Name: update_category(character varying, text, bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION update_category(tit character varying, descrip text, i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update category set title=tit, description=descrip where "id"=i;
end;
$$;


ALTER FUNCTION public.update_category(tit character varying, descrip text, i bigint) OWNER TO postgres;

--
-- Name: update_client(character varying, character varying, character varying, character varying, bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION update_client(nam character varying, addr character varying, phon character varying, emai character varying, i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update client set "name"=nam,phone=phon,address=addr,email=emai where "id"=i;
end;
$$;


ALTER FUNCTION public.update_client(nam character varying, addr character varying, phon character varying, emai character varying, i bigint) OWNER TO postgres;

--
-- Name: update_department(character varying, character varying, character varying, bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION update_department(tit character varying, phon character varying, emai character varying, i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update department set "title"=tit,phone=phon,email=emai where "id"=i;
end;
$$;


ALTER FUNCTION public.update_department(tit character varying, phon character varying, emai character varying, i bigint) OWNER TO postgres;

--
-- Name: update_post(character varying, text, bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION update_post(tit character varying, des text, i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update post set title=tit,description=des where "id"=i;
end;
$$;


ALTER FUNCTION public.update_post(tit character varying, des text, i bigint) OWNER TO postgres;

--
-- Name: update_priority(character varying, bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION update_priority(tit character varying, i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update priority set title=tit where "id"=i;
end;
$$;


ALTER FUNCTION public.update_priority(tit character varying, i bigint) OWNER TO postgres;

--
-- Name: update_request(character varying, text, date, date, bigint, bigint, bigint, bigint, bigint, bigint, bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION update_request(tit character varying, des text, rec date, dead date, cat bigint, oper bigint, cli bigint, prio bigint, imp bigint, stat bigint, i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update request set title=tit,description=des,date_rec=rec, deadline=dead,id_category=cat,id_operator=oper,
	id_client=cli,id_priority=prio,id_implementer=imp,id_status=stat where "id"=i;
end;
$$;


ALTER FUNCTION public.update_request(tit character varying, des text, rec date, dead date, cat bigint, oper bigint, cli bigint, prio bigint, imp bigint, stat bigint, i bigint) OWNER TO postgres;

--
-- Name: update_status(character varying, bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION update_status(tit character varying, i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update status set title=tit where "id"=i;
end;
$$;


ALTER FUNCTION public.update_status(tit character varying, i bigint) OWNER TO postgres;

--
-- Name: update_worker(character varying, character varying, character varying, bigint, bigint, bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION update_worker(nam character varying, addr character varying, phon character varying, dep bigint, post bigint, i bigint) RETURNS void
    LANGUAGE plpgsql
    AS $$
begin
	update worker set "name"=nam, phone=phon,address=addr,id_department=dep,id_post=post where "id"=i;
end;
$$;


ALTER FUNCTION public.update_worker(nam character varying, addr character varying, phon character varying, dep bigint, post bigint, i bigint) OWNER TO postgres;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- Name: category; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE category (
    id bigint NOT NULL,
    title character varying NOT NULL,
    description text,
    del_flag boolean
);


ALTER TABLE category OWNER TO postgres;

--
-- Name: category_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE category_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE category_id_seq OWNER TO postgres;

--
-- Name: category_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE category_id_seq OWNED BY category.id;


--
-- Name: client; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE client (
    id bigint NOT NULL,
    name character varying,
    address character varying,
    phone character varying,
    email character varying,
    del_flag boolean
);


ALTER TABLE client OWNER TO postgres;

--
-- Name: client_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE client_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE client_id_seq OWNER TO postgres;

--
-- Name: client_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE client_id_seq OWNED BY client.id;


--
-- Name: department; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE department (
    title character varying,
    phone character varying,
    email character varying,
    del_flag boolean,
    id bigint NOT NULL
);


ALTER TABLE department OWNER TO postgres;

--
-- Name: department_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE department_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE department_id_seq OWNER TO postgres;

--
-- Name: department_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE department_id_seq OWNED BY department.id;


--
-- Name: post; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE post (
    id bigint NOT NULL,
    title character varying,
    description text,
    del_flag boolean
);


ALTER TABLE post OWNER TO postgres;

--
-- Name: post_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE post_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE post_id_seq OWNER TO postgres;

--
-- Name: post_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE post_id_seq OWNED BY post.id;


--
-- Name: priority; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE priority (
    id bigint NOT NULL,
    title character varying,
    del_flag boolean
);


ALTER TABLE priority OWNER TO postgres;

--
-- Name: priority_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE priority_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE priority_id_seq OWNER TO postgres;

--
-- Name: priority_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE priority_id_seq OWNED BY priority.id;


--
-- Name: request; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE request (
    title character varying,
    description text,
    date_rec date,
    deadline date,
    id_category bigint,
    id_operator bigint,
    id_client bigint,
    id_implementer bigint,
    id_status bigint,
    del_flag boolean,
    id bigint NOT NULL,
    id_priority bigint
);


ALTER TABLE request OWNER TO postgres;

--
-- Name: request_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE request_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE request_id_seq OWNER TO postgres;

--
-- Name: request_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE request_id_seq OWNED BY request.id;


--
-- Name: status; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE status (
    id bigint NOT NULL,
    title character varying,
    del_flag boolean
);


ALTER TABLE status OWNER TO postgres;

--
-- Name: status_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE status_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE status_id_seq OWNER TO postgres;

--
-- Name: status_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE status_id_seq OWNED BY status.id;


--
-- Name: worker; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE worker (
    id bigint NOT NULL,
    name character varying,
    address character varying,
    phone character varying,
    id_department bigint,
    id_post bigint,
    del_flag boolean
);


ALTER TABLE worker OWNER TO postgres;

--
-- Name: worker_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE worker_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE worker_id_seq OWNER TO postgres;

--
-- Name: worker_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE worker_id_seq OWNED BY worker.id;


--
-- Name: category id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY category ALTER COLUMN id SET DEFAULT nextval('category_id_seq'::regclass);


--
-- Name: client id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY client ALTER COLUMN id SET DEFAULT nextval('client_id_seq'::regclass);


--
-- Name: department id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY department ALTER COLUMN id SET DEFAULT nextval('department_id_seq'::regclass);


--
-- Name: post id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY post ALTER COLUMN id SET DEFAULT nextval('post_id_seq'::regclass);


--
-- Name: priority id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY priority ALTER COLUMN id SET DEFAULT nextval('priority_id_seq'::regclass);


--
-- Name: request id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY request ALTER COLUMN id SET DEFAULT nextval('request_id_seq'::regclass);


--
-- Name: status id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY status ALTER COLUMN id SET DEFAULT nextval('status_id_seq'::regclass);


--
-- Name: worker id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY worker ALTER COLUMN id SET DEFAULT nextval('worker_id_seq'::regclass);


--
-- Data for Name: category; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY category (id, title, description, del_flag) FROM stdin;
1	ПК	Персональный компьютер	\N
2	Интернет	Проблемы с интернетом	\N
3	1	1111	t
\.


--
-- Data for Name: client; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY client (id, name, address, phone, email, del_flag) FROM stdin;
1					t
3	Иванов Петр Сергеевич	Петрозаводская, 67	354654764	54765457@mail.ru	\N
2	222	1	1		t
4	Алексеев Дмитрий	Вагонная, 71	46578235	alex@mail.ru	\N
5	1	1			t
\.


--
-- Data for Name: department; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY department (title, phone, email, del_flag, id) FROM stdin;
Диспетчерская	325436346	1234@mail.ru	\N	1
Интернет-мастеры	5645252	6563@mail.ru	\N	2
111	1	1	t	3
\.


--
-- Data for Name: post; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY post (id, title, description, del_flag) FROM stdin;
1	Диспетчер	Принимает заявки	\N
2	Мастер по интернету	Выполняет заявки, связанные с интернетом	\N
3	Мастер по ПК	Выполняет заявки, связанные с ПК	\N
4	1	111	t
\.


--
-- Data for Name: priority; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY priority (id, title, del_flag) FROM stdin;
1	Низкий	\N
2	Средний	\N
3	Высокий	\N
4	Наивысший	\N
5	111	t
\.


--
-- Data for Name: request; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY request (title, description, date_rec, deadline, id_category, id_operator, id_client, id_implementer, id_status, del_flag, id, id_priority) FROM stdin;
2	\N	\N	\N	\N	\N	\N	\N	\N	\N	1	\N
Сломался ПК	Отказывается запускаться	2019-03-06	2019-03-15	1	1	3	2	2	\N	2	2
\.


--
-- Data for Name: status; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY status (id, title, del_flag) FROM stdin;
1	Принято	\N
2	В процессе	\N
3	Завершено	\N
4	11111	t
\.


--
-- Data for Name: worker; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY worker (id, name, address, phone, id_department, id_post, del_flag) FROM stdin;
1	Иванов Иван Петрович	Песочная, 45	4357634	1	1	\N
2	Петров Иван Иванович	Лесная, 78	45476346	2	2	\N
3	1	2	1	1	1	t
\.


--
-- Name: category_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('category_id_seq', 3, true);


--
-- Name: client_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('client_id_seq', 5, true);


--
-- Name: department_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('department_id_seq', 3, true);


--
-- Name: post_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('post_id_seq', 4, true);


--
-- Name: priority_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('priority_id_seq', 5, true);


--
-- Name: request_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('request_id_seq', 2, true);


--
-- Name: status_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('status_id_seq', 4, true);


--
-- Name: worker_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('worker_id_seq', 3, true);


--
-- Name: category category_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY category
    ADD CONSTRAINT category_pkey PRIMARY KEY (id);


--
-- Name: client client_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY client
    ADD CONSTRAINT client_pkey PRIMARY KEY (id);


--
-- Name: department department_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY department
    ADD CONSTRAINT department_pkey PRIMARY KEY (id);


--
-- Name: post post_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY post
    ADD CONSTRAINT post_pkey PRIMARY KEY (id);


--
-- Name: priority priority_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY priority
    ADD CONSTRAINT priority_pkey PRIMARY KEY (id);


--
-- Name: request request_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY request
    ADD CONSTRAINT request_pkey PRIMARY KEY (id);


--
-- Name: status status_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY status
    ADD CONSTRAINT status_pkey PRIMARY KEY (id);


--
-- PostgreSQL database dump complete
--

