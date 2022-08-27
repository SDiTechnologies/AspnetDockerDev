/** enable and use uuid random generator in postgres*/
-- CREATE EXTENSION IF NOT EXISTS "uuid-ossp";
-- SELECT uuid_generate_v4() as "UUID";

/** valid uuid4 without extension */
-- SELECT uuid_in(overlay(overlay(md5(random()::text || ':' || random()::text) placing '4' from 13) placing to_hex(floor(random()*(11-8+1) + 8)::int)::text from 17)::cstring);

/** invalid uuid without extension */
-- SELECT uuid_in(md5(random()::text || random()::text)::cstring);
