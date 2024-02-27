services.AddDbContext<TodoContext>(opt =>
    opt.UseSqlite(Configuration.GetConnectionString("TodoContext")));