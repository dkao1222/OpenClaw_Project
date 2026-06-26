# OPDCA + DMAIC Validation

- status: failed
- checks_total: 10
- checks_failed: 10

## Checks

- FAIL raw_idea_defined: status/context/Raw_Idea.md; marker:Game Concept; marker:Core Gameplay; marker:Success Criteria
- FAIL define_contract_present: docs/define/Defined_Request.md; marker:Product Experience Contract; marker:Human Playability; marker:Visual Richness
- FAIL planning_depth_present: docs/planning/Game_Proposal.md; docs/planning/proposal/Primary_Objects_and_Rules.md; marker:First 10; marker:hazard; marker:boost; marker:retry
- FAIL spec_review_actionable: docs/review/Gameplay_Detail_Spec.md; docs/review/Control_System_Detail_Spec.md; marker:input; marker:state; marker:QA; marker:acceptance
- FAIL development_unity_project_present: unity/NeonDrift/ProjectSettings/ProjectVersion.txt; unity/NeonDrift/Assets/Scenes/Main.unity
- FAIL development_runtime_probe_present: unity/NeonDrift/Assets/Scripts/RuntimeQaProbe.cs; marker:qa; marker:probe
- FAIL build_evidence_present: status/validation/build_full_validation.md; marker:status: passed
- FAIL qa_evidence_present: status/validation/qa_full_validation.md; status/qa/full_qa_report.md; marker:product_experience; marker:visual; marker:playthrough; marker:video
- FAIL qa_hard_gates_present: status/qa/full_qa_report.md; status/qa/qa_result.json; marker:human; marker:gameplay; marker:visual; marker:playthrough_video
- FAIL qa_runtime_evidence_artifacts_present: status/qa/evidence/raw_evidence.json; status/qa/screenshots/ios_simulator_menu.png; status/qa/screenshots/ios_simulator_gameplay.png
