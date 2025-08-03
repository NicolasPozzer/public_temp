import psycopg2
from psycopg2 import OperationalError

def test_postgres_connection():
    try:
        conn = psycopg2.connect(
            host="",
            database="",
            user="",
            password="",
            port="",
            sslmode='require'
        )
        print("✅ Conexión exitosa")
        conn.close()
    except OperationalError as e:
        print("❌ Error al conectar a PostgreSQL:")
        print(e)

if __name__ == "__main__":
    test_postgres_connection()