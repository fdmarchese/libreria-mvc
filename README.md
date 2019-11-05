# libreria-mvc

Crear un nuevo proyecto MVC llamado "Libreria"

Instalar entity framework core desde nuget.

Agregar las siguientes clases dentro de la carpeta "Model":

Editorial
 - Id : int (clave primaria)
 - Nombre : string (máximo de 100 caracteres) (requerido)
 - ICollection&lt;Libro&gt; Libros (libros que publicó una editorial)

Genero
 - Id : int (clave primaria)
 - Nombre : string (máximo de 50 caracteres) (requerido)
 - ClaseCss : string (máximo 50 caracteres) (no requerido) (esta propiedad es para establecer la clase de css que se le va a aplicar a los libros de cada género cuando se muestren por pantalla)
 - Libros : ICollection&lt;Libro&gt; (lista de libros que pertenecen a un género)

Autor
 - Id : int (clave primaria)
 - Nombre : string (máximo de 100 caracteres) (requerido)
 - Apellido : string (máximo de 100 caracteres) (requerido)
 - LibrosAutor : ICollection&lt;LibroAutor&gt; (colección de libros del autor) (notar que se maneja con una entidad intermedia "LibroAutor" ya que se trata de una relación de tipo muchos a muchos y por lo tanto al igual que en base de datos se resuelve el problema de esta forma).

LibroAutor (entidad necesaria para hacer una relación de muchos libros con muchos autores, en otras palabras un autor puede haber escrito muchos libros y un libro pudo ser escrito por más de un autor)
 - AutorId : int (clave foránea con un autor)
 - Autor : Autor (relación con un autor)
 - LibroId : int (clave foránea con un libro)
 - Libro : Libro (relación con un libro)

Libro
 - Id : int (ésta será la clave primaria)
 - Titulo : string (máximo de 100 caracteres) (requerido)
 - AnioPublicado : int? (No requerido)
 - Stock : int (requerido)
 - EditorialId : int (un libro tiene que tener una editorial sí o sí,  entonces esta relación debe ser no nulable. Si quisiera que pueda existir un libro sin editorial aquí se debería usar int? en lugar de int)
 - Editorial : Editorial (un libro es de una editorial)
 - GeneroId : int (clave foránea con género)
 - Genero : Genero (relación con género)
 - Autores : ICollection&lt;AutorLibro&gt; (un libro puede tener muchos autores).


Crear una nueva carpeta dentro del proyecto de MVC que se llame Database.

Dentro de la carpeta creada crear una nueva clase y llamarla LibreriaDbContext.

Esa nueva clase funcionará como nuestro contexto de base de datos de EF, por lo tanto debe heredar de la clase de EF "DbContext"

Crear las propiedades dentro de esa clase para los set de datos que entity framework usará,  éstos son:
 - Editoriales : DbSet&lt;Editorial&gt;
 - Generos : DbSet&lt;Genero&gt;
 - Autores : DbSet&lt;Autor&gt;
 - LibrosAutores : DbSet&lt;LibroAutor&gt;
 - Libros : DbSet&lt;Libro&gt;

Configurar en Startup.cs la base de datos a utilizar. 
