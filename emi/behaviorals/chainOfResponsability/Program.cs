// In a company, every expense is approved by the first level
// with sufficient authority: the
// supervisor (up to $50,000), the manager (up to $200,000), and the director (no limit).
// Whoever submits an
// expense always presents it to the supervisor, without knowing
// who will ultimately approve it.

// The company plans to add an “area head” level between
// the supervisor and the manager. This change should be implemented
// by adding the new level and restructuring the sequence, without
// modifying the existing levels.

using chainOfResponsability;
using chainOfResponsability.approvals;

Handler supervisor = new SupervisorApproval();
Handler manager = new ManagerApproval();
Handler director = new DirectorApproval();

manager.setNext(director);
supervisor.setNext(manager);

supervisor.handle(150000);