# Development To Build Evidence Gate

- status: failed
- checks_total: 13
- checks_failed: 13

## Checks

- FAIL required_file:unity/NeonDrift/ProjectSettings/ProjectVersion.txt: missing
- FAIL required_file:unity/NeonDrift/Assets/Scenes/Main.unity: missing
- FAIL required_file:unity/NeonDrift/Assets/Scripts/RuntimeQaProbe.cs: missing
- FAIL required_file:docs/qa/MVP_QA_Test_Plan.md: missing
- FAIL required_file:docs/qa/Phase1_MVP_QA_Report.md: missing
- FAIL required_file:status/context/Current_Status_Summary.md: missing
- FAIL product_experience_evidence: missing_any_of=product experience|human|readability|player
- FAIL visual_richness_evidence: missing_any_of=visual|style|background|effect
- FAIL gameplay_function_evidence: missing_any_of=start|left|right|retry|pause
- FAIL runtime_qa_probe_evidence: missing_any_of=runtime qa|probe|screenshot|video
- FAIL repeated_qa_playthrough_evidence: missing_any_of=three-cycle qa|3 complete playthrough|repeated playthrough
- FAIL non_placeholder_policy: missing_any_of=placeholder|static|debug-looking
- FAIL unity_runtime_scripts_present: cs_files=0

## Rule

Build cannot start unless Development provides concrete Unity project, runtime QA, product experience, visual richness, and gameplay-function evidence.
