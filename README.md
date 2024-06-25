# IClinicBot BackEnd
# Diagrama de Classe
![DiagramaClasseIClinicBot](https://github.com/Correiakaue0/IClinicBot_BackEnd/assets/99895282/bd4d30dc-2dd0-4494-8ac8-a5dabb30dc58)
Enums:
MedicalExam -> EnumExamType("Hemograma", "Raio-X", "Eletrocardiograma", "Audiometria" ...)
Scheduling -> EnumStatus("Available", "Busy")
MedicalAppointment -> EnumAppointmentType("NewAppointment", "ReturnAppointment")
MedicalAppointment -> EnumConsultationType("Presential", "ChatBot")
MedicalAppointment -> EnumStatus("Completed", "Rescheduled", "Missed")
