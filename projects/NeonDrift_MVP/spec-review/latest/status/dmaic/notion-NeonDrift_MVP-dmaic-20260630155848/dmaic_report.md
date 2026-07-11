# OPDCA + DMAIC Pipeline Review

## Summary

- status: failed
- project_name: NeonDrift_MVP
- chain_id: raw:NeonDrift_MVP:20260628092620
- run_id: notion-NeonDrift_MVP-dmaic-20260630155848
- source_pipeline: qa
- checks_total: 11
- checks_failed: 1
- knowledge_base: workspace/public_document/knowledge_base/game_quality/OPDCA_DMAIC_CYCLE.md

## OPDCA

- Observe: Collect completed pipeline state, generated files, Notion row metadata, QA evidence, and validation reports.
- Plan: Route to DMAIC root-cause analysis because one or more OPDCA checks failed.
- Do: Run OPDCA evidence checks and DMAIC quality analysis for source pipeline 'qa'.
- Check: 1 failed checks detected.
- Act: Close the loop as control monitoring; do not create remediation.

## DMAIC - Define

- Problem statement: pipeline output must be detailed, playable, visually rich, evidence-backed, and traceable from raw idea to QA.
- Customer requirement: Notion must show whether planning/spec/development/build/QA evidence is sufficient before advancing.

## DMAIC - Measure

- PASS raw_idea_defined: passed
- PASS define_contract_present: passed
- PASS planning_depth_present: passed
- PASS spec_review_actionable: passed
- PASS development_unity_project_present: passed
- PASS development_runtime_probe_present: passed
- PASS build_evidence_present: passed
- PASS qa_evidence_present: passed
- PASS qa_hard_gates_present: passed
- PASS qa_runtime_evidence_artifacts_present: passed
- FAIL pipeline_chain_continuity: expected=raw:NeonDrift_MVP:20260628092620 observed=['raw:NeonDrift_MVP:20260630155009'] mismatched=['raw:NeonDrift_MVP:20260630155009']

## DMAIC - Analyze

- pipeline_chain_continuity: expected=raw:NeonDrift_MVP:20260628092620 observed=['raw:NeonDrift_MVP:20260630155009'] mismatched=['raw:NeonDrift_MVP:20260630155009']

## Root Causes

- control_monitoring -> control: No failed DMAIC checks; keep monitoring regression signals.

## DMAIC - Improve

- remediation_target: none
- Return to QA/Development loop: require simulator video, screenshots, product experience, human visual judgement, and every core gameplay function evidence.

## Remediation Request

No remediation row required. Continue OPDCA Control monitoring.

## DMAIC - Control

- Keep this DMAIC row linked by Chain ID and source page.
- OPDCA Act decides whether to create remediation or close as control monitoring.
- Any future QA pass without product experience, human visual judgement, function playability, and recording evidence must remain failed.
- Any Development pass without runtime implementation evidence must be blocked before Build.

## QA Failure Signals

| qa_retry_live_motion_after_retry_gate | Gameplay | FAIL | retryProbePresent=True, retryLiveProbePresent=False, retryScreenState='gameplay', retryLiveScreenState=None, retryGameplayTime=0.8158696889877319, retryLiveGameplayTime=None, retry
| qa_retry_restarts_gameplay_gate | Gameplay | FAIL | retryRestartsGameplayVerified=True, RetryRestartsGameplay=True, RawRetryRestartsMovingGameplay=False, gameOverToRetryChanged=True, retryVisualStateVisible=True. | /home/node/.openclaw/wo
| qa_human_visual_judgement_gate | Visual | FAIL | videoExists=True, menuScreenshot=True, gameplayScreenshot=True, gameOverScreenshot=True, retryScreenshot=True, retryLiveScreenshot=True, menuToGameplayChanged=True, gameplayToGameOverChange
| qa_product_experience_gate | Gameplay | FAIL | menuLayoutVerified=True, menuElementsDoNotOverlap=True, gameplayHudHiddenInMenu=True, gameplayControlsHiddenInMenu=True, menuHumanReadable=True, hasObjectiveText=True, hasAvoidInstructionText
| qa_common_sense_veto_gate | UI/UX | FAIL | commonSenseVetoFailures=qa_retry_live_motion_after_retry_gate=FAIL, qa_retry_restarts_gameplay_gate=FAIL, qa_human_visual_judgement_gate=FAIL, qa_product_experience_gate=FAIL; dependencyStatuses=
- status: failed
- qa_overall_status: failed
"expected": "QA must fail whenever the product feels unreasonable to a human: confusing gameplay, inert motion, unclear objective, unclear controls, weak visual feedback, overlapping states, placeholder visuals, missing audio/feedback evide
