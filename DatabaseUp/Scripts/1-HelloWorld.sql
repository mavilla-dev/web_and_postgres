-- throw away table to ensure DBUp works
-- Delete this after c# dbup code works
CREATE TABLE my_first_table (
    id        serial primary key not null
    ,title    varchar(40) NOT NULL
)