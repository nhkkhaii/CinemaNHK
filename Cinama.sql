select v.SOVE as 'Số vé',p.TENPHIM as 'Phim',tl.TENTHELOAI as 'Thể loại',p.GIAPHIM as 'Giá',p.NGAYCHIEUPHIM 'Ngày chiếu' ,sc.GIOCHIEU as 'Giờ chiếu',
kh.HOTENKHACHHANG as 'Tên khách hàng' ,r.TENRAP as 'Tên Rạp', pc.TENPHONG as 'Phòng chiếu',g.SOGHE as 'Ghế',nv.HOTENNV as 'Nhân Viên Lập'
from VE v,SUATCHIEU sc,GHE g,NHANVIEN nv,KHACHHANG kh,PHIM p,THELOAI tl,PHONGCHIEU pc, RAP r
where v.KHACHHANGID = kh.KHACHHANGID
and v.SUATCHIEUID = sc.SUATCHIEUID
and v.SOGHEID = g.SOGHEID
and v.NHANVIENID = nv.NHANVIENID
and p.PHIMID = sc.PHIMID
and p.THELOAIID = tl.THELOAIID
and r.RAPID = pc.RAPID
and sc.SUATCHIEUID = pc.SUATCHIEUID
and g.PHONGCHIEUID = pc.PHONGCHIEUID
and p.PHIMID = 'CTVT'
and sc.SUATCHIEUID = 'N002'
and r.RAPID = 'RAP01'
and pc.PHONGCHIEUID = 'P002'

select P.TENPHIM,P.NGAYCHIEUPHIM,R.TENRAP,PC.TENPHONG,SC.GIOCHIEU 
from PHIM P, SUATCHIEU SC , PHONGCHIEU PC , RAP R
WHERE P.PHIMID = SC.PHIMID
AND SC.SUATCHIEUID = PC.SUATCHIEUID
AND R.RAPID = PC.RAPID
and P.PHIMID = 'CTVT'
and R.RAPID = 'RAP01'
and SC.SUATCHIEUID = 'N01'
and PC.PHONGCHIEUID = 'P001'

select g.SOGHEID , g.SOGHE
from GHE g,PHONGCHIEU pc
where g.PHONGCHIEUID = pc.PHONGCHIEUID
and g.SOGHE = 'A02'
and pc.PHONGCHIEUID = 'P002'
if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GHE') and o.name = 'FK_GHE_PHONG_PHONGCHI')
alter table GHE
   drop constraint FK_GHE_PHONG_PHONGCHI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIM') and o.name = 'FK_PHIM_GOM_THELOAI')
alter table PHIM
   drop constraint FK_PHIM_GOM_THELOAI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHONGCHIEU') and o.name = 'FK_PHONGCHI_TAI_SUATCHIE')
alter table PHONGCHIEU
   drop constraint FK_PHONGCHI_TAI_SUATCHIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHONGCHIEU') and o.name = 'FK_PHONGCHI_TRONG_RAP')
alter table PHONGCHIEU
   drop constraint FK_PHONGCHI_TRONG_RAP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SUATCHIEU') and o.name = 'FK_SUATCHIE_GIO_PHIM')
alter table SUATCHIEU
   drop constraint FK_SUATCHIE_GIO_PHIM
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VE') and o.name = 'FK_VE_BAN_NHANVIEN')
alter table VE
   drop constraint FK_VE_BAN_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VE') and o.name = 'FK_VE_CHIEU_SUATCHIE')
alter table VE
   drop constraint FK_VE_CHIEU_SUATCHIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VE') and o.name = 'FK_VE_GHE_GHE')
alter table VE
   drop constraint FK_VE_GHE_GHE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VE') and o.name = 'FK_VE_MUA_KHACHHAN')
alter table VE
   drop constraint FK_VE_MUA_KHACHHAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GHE')
            and   name  = 'GHE_FK'
            and   indid > 0
            and   indid < 255)
   drop index GHE.GHE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GHE')
            and   type = 'U')
   drop table GHE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHACHHANG')
            and   type = 'U')
   drop table KHACHHANG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANVIEN')
            and   type = 'U')
   drop table NHANVIEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIM')
            and   type = 'U')
   drop table PHIM
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHONGCHIEU')
            and   name  = 'TRONG_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHONGCHIEU.TRONG_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHONGCHIEU')
            and   type = 'U')
   drop table PHONGCHIEU
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RAP')
            and   type = 'U')
   drop table RAP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SUATCHIEU')
            and   name  = 'GIO_FK'
            and   indid > 0
            and   indid < 255)
   drop index SUATCHIEU.GIO_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SUATCHIEU')
            and   type = 'U')
   drop table SUATCHIEU
go

if exists (select 1
            from  sysobjects
           where  id = object_id('THELOAI')
            and   type = 'U')
   drop table THELOAI
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VE')
            and   name  = 'NGOI_FK'
            and   indid > 0
            and   indid < 255)
   drop index VE.NGOI_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VE')
            and   name  = 'GHE_FK'
            and   indid > 0
            and   indid < 255)
   drop index VE.GHE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VE')
            and   name  = 'CHIEU_FK'
            and   indid > 0
            and   indid < 255)
   drop index VE.CHIEU_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VE')
            and   name  = 'MUA_FK'
            and   indid > 0
            and   indid < 255)
   drop index VE.MUA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VE')
            and   name  = 'BAN_FK'
            and   indid > 0
            and   indid < 255)
   drop index VE.BAN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VE')
            and   type = 'U')
   drop table VE
go

/*==============================================================*/
/* Table: GHE                                                   */
/*==============================================================*/
create table GHE (
   SOGHEID              int      Identity(1,1)            not null,
   SOGHE                varchar(3)           not null,
   PHONGCHIEUID         varchar(10)          not null,
   constraint PK_GHE primary key nonclustered (SOGHEID)
)
go

/*==============================================================*/
/* Index: GHE_FK                                                */
/*==============================================================*/
create index GHE_FK on GHE (
PHONGCHIEUID ASC
)
go

/*==============================================================*/
/* Table: KHACHHANG                                             */
/*==============================================================*/
create table KHACHHANG (
   KHACHHANGID          int Identity(1,1)                 not null,
   SOTKKH               char(20)             null,
   MATKHAUTKKH          char(50)             null,
   HOTENKHACHHANG       nvarchar(30)          null,
   SDTKHACHHANG         char(11)             null,
   DIACHIKHACHHANG      nvarchar(50)          null,
   EMAILKHACHHANG       varchar(30)             null,
   NGAYSINHKHACHHANG    datetime             null,
   constraint PK_KHACHHANG primary key nonclustered (KHACHHANGID)
)
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   NHANVIENID           varchar(20)          not null,
   SOTKNV               char(20)             null,
   MATKHAUTKNV          char(50)             null,
   HOTENNV              nvarchar(30)          null,
   SDTNV                char(11)             null,
   DIACHINV             nvarchar(50)          null,
   EMAILNV              varchar(30)             null,
   NGAYSINHNV           datetime             null,
   CHUCVU               nvarchar(10)          null,
   constraint PK_NHANVIEN primary key nonclustered (NHANVIENID)
)
go

/*==============================================================*/
/* Table: PHIM                                                  */
/*==============================================================*/
create table PHIM (
   PHIMID               varchar(20)          not null,
   THELOAIID            varchar(20)          not null,
   TENPHIM              nvarchar(100)         null,
   NGAYCHIEUPHIM        datetime             null,
   POSTER               image                null,
   GIAPHIM              decimal(6,3)           null,
   constraint PK_PHIM primary key nonclustered (PHIMID)
)
go

/*==============================================================*/
/* Table: PHONGCHIEU                                            */
/*==============================================================*/
create table PHONGCHIEU (
   PHONGCHIEUID         varchar(10)          not null,
   RAPID                varchar(20)          not null,
   SUATCHIEUID          varchar(20)          not null,
   TENPHONG             nvarchar(20)          null,
   constraint PK_PHONGCHIEU primary key nonclustered (PHONGCHIEUID)
)
go

/*==============================================================*/
/* Index: TRONG_FK                                              */
/*==============================================================*/
create index TRONG_FK on PHONGCHIEU (
RAPID ASC
)
go

/*==============================================================*/
/* Table: RAP                                                   */
/*==============================================================*/
create table RAP (
   RAPID                varchar(20)          not null,
   TENRAP               nvarchar(100)         null,
   constraint PK_RAP primary key nonclustered (RAPID)
)
go

/*==============================================================*/
/* Table: SUATCHIEU                                             */
/*==============================================================*/
create table SUATCHIEU (
   SUATCHIEUID          varchar(20)          not null,
   PHIMID               varchar(20)          not null,
   GIOCHIEU             char(10)             null,
   constraint PK_SUATCHIEU primary key nonclustered (SUATCHIEUID)
)
go

/*==============================================================*/
/* Index: GIO_FK                                                */
/*==============================================================*/
create index GIO_FK on SUATCHIEU (
PHIMID ASC
)
go

/*==============================================================*/
/* Table: THELOAI                                               */
/*==============================================================*/
create table THELOAI (
   THELOAIID            varchar(20)          not null,
   TENTHELOAI           nvarchar(10)          null,
   constraint PK_THELOAI primary key nonclustered (THELOAIID)
)
go

/*==============================================================*/
/* Table: VE                                                    */
/*==============================================================*/
create table VE (
   SOVE                 int      Identity(1,1)            not null,
   SUATCHIEUID          varchar(20)          not null,
   SOGHEID              int                  not null,
   NHANVIENID           varchar(20)          not null,
   KHACHHANGID          int                  not null,
   constraint PK_VE primary key nonclustered (SOVE)
)
go

/*==============================================================*/
/* Index: BAN_FK                                                */
/*==============================================================*/
create index BAN_FK on VE (
NHANVIENID ASC
)
go

/*==============================================================*/
/* Index: MUA_FK                                                */
/*==============================================================*/
create index MUA_FK on VE (
KHACHHANGID ASC
)
go

/*==============================================================*/
/* Index: GHE_FK                                                */
/*==============================================================*/
create index GHE_FK on VE (
SOGHEID ASC
)
go


alter table GHE
   add constraint FK_GHE_PHONG_PHONGCHI foreign key (PHONGCHIEUID)
      references PHONGCHIEU (PHONGCHIEUID)
go

alter table PHIM
   add constraint FK_PHIM_GOM_THELOAI foreign key (THELOAIID)
      references THELOAI (THELOAIID)
go

alter table PHONGCHIEU
   add constraint FK_PHONGCHI_TAI_SUATCHIE foreign key (SUATCHIEUID)
      references SUATCHIEU (SUATCHIEUID)
go

alter table PHONGCHIEU
   add constraint FK_PHONGCHI_TRONG_RAP foreign key (RAPID)
      references RAP (RAPID)
go

alter table SUATCHIEU
   add constraint FK_SUATCHIE_GIO_PHIM foreign key (PHIMID)
      references PHIM (PHIMID)
go

alter table VE
   add constraint FK_VE_BAN_NHANVIEN foreign key (NHANVIENID)
      references NHANVIEN (NHANVIENID)
go

alter table VE
   add constraint FK_VE_CHIEU_SUATCHIE foreign key (SUATCHIEUID)
      references SUATCHIEU (SUATCHIEUID)
go

alter table VE
   add constraint FK_VE_GHE_GHE foreign key (SOGHEID)
      references GHE (SOGHEID)
go

alter table VE
   add constraint FK_VE_MUA_KHACHHAN foreign key (KHACHHANGID)
      references KHACHHANG (KHACHHANGID)
go
