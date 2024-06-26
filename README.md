# IClinicBot BackEnd
# Diagrama de Classe
![DiagramaClasseIClinicBot](https://github.com/Correiakaue0/IClinicBot_BackEnd/assets/99895282/bd4d30dc-2dd0-4494-8ac8-a5dabb30dc58)
Enums:
MedicalExam -> EnumExamType("Hemograma", "Raio-X", "Eletrocardiograma", "Audiometria" ...) <br/>
Scheduling -> EnumStatus("Available", "Busy") <br/>
MedicalAppointment -> EnumAppointmentType("NewAppointment", "ReturnAppointment") <br/>
MedicalAppointment -> EnumConsultationType("Presential", "ChatBot") <br/>
MedicalAppointment -> EnumStatus("Completed", "Rescheduled", "Missed") <br/>
