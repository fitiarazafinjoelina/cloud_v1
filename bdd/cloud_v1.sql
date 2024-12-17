CREATE TABLE "user"(
    "id_user" SERIAL NOT NULL,
    "email" VARCHAR(255) NOT NULL,
    "username" VARCHAR(255) NOT NULL,
    "password" VARCHAR(255) NOT NULL,
    "id_role" INTEGER NOT NULL
);


ALTER TABLE
    "user" ADD PRIMARY KEY("id_user");
CREATE TABLE "role"(
    "id_role" SERIAL NOT NULL,
    "role" VARCHAR(255) NOT NULL
);
ALTER TABLE
    "role" ADD PRIMARY KEY("id_role");
ALTER TABLE
    "user" ADD CONSTRAINT "user_id_role_foreign" FOREIGN KEY("id_role") REFERENCES "role"("id_role");