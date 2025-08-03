



class PagoInscripcionSchema(Model):
    nombre: str
    apellido: str


@router.get("/finanzas/detalles-pagos-inscripcion", respone_model=List[PagoIncripcionSchema])
def lista_de_pagos_inscripcion(db: Session(get_db)):

    # buscar usuarios que tengan pagada la inscripcion
    usuarios = db.Usuario().filter(Usuario.postulacionCompleta == true).all

    if not usuarios:
        raise http.exception(404, "No hay usuarios que hayan pagado inscripcion")

    usuarios_inscriptos = []

    for usuario in usuarios:
        user_dto = PagoInscripcionSchema(
                "nombre"=usuario.nombre_completo,
                "apellido"=usuario.apellido_paterno
                )

        # agregar usuario dto a la lista
        usuarios_inscriptos.add(user_dto)


    return usuarios_inscriptos
        
        
        
