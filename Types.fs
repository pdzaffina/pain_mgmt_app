type PainLevel = PainLevel of int // int between 0 and 10

type BodyPart =
| Head
| Chest
| Stomach
| LeftArm
| RightArm  
| LeftLeg
| RightLeg
| Neck
| LeftFoot
| RightFoot

type PainArea = PainArea of BodyPart

type PainLocation = PainLocation of string

type PainType = 
| Ache
| Burn
| Throbbing
| Sharp

type MedicineType = 
| Acetaminophen
| Excedrin
| Aspirin
| Ibuprofen

type Dose = Dose of int

type MedicineTreatment = {
    MedicineType: MedicineType
    Dose: Dose
}


type PainRecord = {
    
    PainLevel: PainLevel
    PainArea: PainArea
    PainTime: DateTime
    PainLocation: PainLocation
    PainType: PainType
    MedicineTreatment: MedicineTreatment
    }