# OPDCA + DMAIC Pipeline Review

## Summary

- status: failed
- project_name: NeonDrift_MVP
- chain_id: raw:NeonDrift_MVP:20260626162600
- run_id: notion-NeonDrift_MVP-dmaic-20260626162745
- source_pipeline: development
- checks_total: 10
- checks_failed: 10
- knowledge_base: workspace/public_document/knowledge_base/game_quality/OPDCA_DMAIC_CYCLE.md

## OPDCA

- Observe: Collect completed pipeline state, generated files, Notion row metadata, QA evidence, and validation reports.
- Plan: Route to DMAIC root-cause analysis because one or more OPDCA checks failed.
- Do: Run OPDCA evidence checks and DMAIC quality analysis for source pipeline 'development'.
- Check: 10 failed checks detected.
- Act: Create remediation row targeting spec-review and require concrete runtime/product evidence before passing.

## DMAIC - Define

- Problem statement: pipeline output must be detailed, playable, visually rich, evidence-backed, and traceable from raw idea to QA.
- Customer requirement: Notion must show whether planning/spec/development/build/QA evidence is sufficient before advancing.

## DMAIC - Measure

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

## DMAIC - Analyze

- raw_idea_defined: status/context/Raw_Idea.md; marker:Game Concept; marker:Core Gameplay; marker:Success Criteria
- define_contract_present: docs/define/Defined_Request.md; marker:Product Experience Contract; marker:Human Playability; marker:Visual Richness
- planning_depth_present: docs/planning/Game_Proposal.md; docs/planning/proposal/Primary_Objects_and_Rules.md; marker:First 10; marker:hazard; marker:boost; marker:retry
- spec_review_actionable: docs/review/Gameplay_Detail_Spec.md; docs/review/Control_System_Detail_Spec.md; marker:input; marker:state; marker:QA; marker:acceptance
- development_unity_project_present: unity/NeonDrift/ProjectSettings/ProjectVersion.txt; unity/NeonDrift/Assets/Scenes/Main.unity
- development_runtime_probe_present: unity/NeonDrift/Assets/Scripts/RuntimeQaProbe.cs; marker:qa; marker:probe
- build_evidence_present: status/validation/build_full_validation.md; marker:status: passed
- qa_evidence_present: status/validation/qa_full_validation.md; status/qa/full_qa_report.md; marker:product_experience; marker:visual; marker:playthrough; marker:video
- qa_hard_gates_present: status/qa/full_qa_report.md; status/qa/qa_result.json; marker:human; marker:gameplay; marker:visual; marker:playthrough_video
- qa_runtime_evidence_artifacts_present: status/qa/evidence/raw_evidence.json; status/qa/screenshots/ios_simulator_menu.png; status/qa/screenshots/ios_simulator_gameplay.png

## Root Causes

- upstream_spec_gap -> planning_or_spec_review: Planning or Spec Review lacks actionable gameplay, state, QA, or implementation detail.
- development_evidence_gap -> development: Unity project or runtime QA probe source evidence is missing or incomplete.
- build_evidence_gap -> build: Build validation evidence is missing or not passed.
- qa_evidence_gap -> qa: QA evidence package is incomplete.

## DMAIC - Improve

- remediation_target: spec-review
- Improve Planning and Spec Review cards: require concrete first-10-second gameplay, object rules, state transitions, QA acceptance, and downstream file references.
- Return to Development: generate Unity runtime probe, scene, scripts, and implementation evidence before Build can start.
- Return to QA/Development loop: require simulator video, screenshots, product experience, human visual judgement, and every core gameplay function evidence.
- Build watcher must rerun local Unity build and publish build_full_validation.md before QA.
- Create remediation Notion row targeting spec-review; do not stop at reporting.

## Remediation Request

DMAIC remediation target: spec-review

Root causes:
- upstream_spec_gap: Planning or Spec Review lacks actionable gameplay, state, QA, or implementation detail.
- development_evidence_gap: Unity project or runtime QA probe source evidence is missing or incomplete.
- build_evidence_gap: Build validation evidence is missing or not passed.
- qa_evidence_gap: QA evidence package is incomplete.

Required correction:
- Do not mark the remediation passed unless generated runtime/product evidence directly resolves the listed root causes.
- Preserve the Chain ID and source DMAIC report for traceability.
- If returning to Development, fix implementation, visual readability, gameplay playability, runtime QA probe/evidence, and retry/menu/gameplay states before Build.
- If returning to QA, rerun simulator QA and produce screenshots, video/recording evidence, raw evidence JSON, and human product-experience checks.

Observed QA failure signals:

## DMAIC - Control

- Keep this DMAIC row linked by Chain ID and source page.
- OPDCA Act decides whether to create remediation or close as control monitoring.
- Any future QA pass without product experience, human visual judgement, function playability, and recording evidence must remain failed.
- Any Development pass without runtime implementation evidence must be blocked before Build.

## QA Failure Signals

- none
