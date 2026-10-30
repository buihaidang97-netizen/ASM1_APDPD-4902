// Unhelpful: repeats the code
i++; // increase i
 
// Useful: records a business rule that the code alone cannot explain
// A late check-in after 15 minutes is recorded as Late, not Absent (university policy).
if (checkInTime > slot.StartTime.AddMinutes(15))
{
    attendance.Status = AttendanceStatus.Late;
}
